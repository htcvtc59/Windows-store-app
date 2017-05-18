using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Plus.v1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ASMGmailAWSAD2.UserProfileInfo;

namespace ASMGmailAWSAD2
{
    class ServiceGmail
    {
        static string ApplicationName = "Gmail API";

        //GmailService.Scope.GmailMetadata ,
        public async Task<UserCredential> getCredential()
        {
            UserCredential credential;
            string[] Scopes = { GmailService.Scope.MailGoogleCom,GmailService.Scope.GmailModify,GmailService.Scope.GmailReadonly,
            GmailService.Scope.GmailCompose, GmailService.Scope.GmailSend , PlusService.Scope.UserinfoProfile ,
                PlusService.Scope.UserinfoEmail};
            Uri uri = new Uri("ms-appx:///ClientScret/client_secret");
            credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(uri, Scopes, "user", CancellationToken.None);
            return credential;
        }

        public async Task<UserProfile> getProfileService(UserCredential credential)
        {
            UserProfile userInfo = null;
            if (credential != null)
            {
                string idToken = credential.Token.IdToken;
                userInfo = await UserProfileInfo.getProfile(idToken);

            }
            return userInfo;
        }


        public List<MesHeader> getAllMail(UserCredential credential)
        {
            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            //get Message id and threadid
            List<Message> resultMes = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List("me");
            request.LabelIds = "INBOX";
            ListMessagesResponse response = request.Execute();
            resultMes.AddRange(response.Messages);
            request.PageToken = response.NextPageToken;

            //get Detail Message
            List<Message> resultDetail = new List<Message>();
            foreach (var item in resultMes)
            {
                Message mes = new Message();
                Message mesd = service.Users.Messages.Get("me", item.Id).Execute();
                mes.Snippet = mesd.Snippet;
                mes.Id = mesd.Id;
                mes.LabelIds = mesd.LabelIds;
                mes.Payload = mesd.Payload;
                resultDetail.Add(mes);
            }

            List<MesHeader> mesLHeader = new List<MesHeader>();

            foreach (Message itemmes in resultDetail)
            {
                MesHeader mes = new MesHeader();
                mes.txt3 = itemmes.Snippet;
                foreach (var item in itemmes.Payload.Headers)
                {

                    if (item.Name == "From")
                    {
                        mes.txt1 = item.Value;
                    }
                    else if (item.Name == "Subject")
                    {
                        mes.txt2 = item.Value;

                    }
                    else if (item.Name == "Date")
                    {
                        mes.txt4 = item.Value;
                    }

                }
                //get content

                if (itemmes.Payload.Parts != null)
                {
                    foreach (var item in itemmes.Payload.Parts)
                    {
                        if (item.MimeType == "text/html")
                        {
                            mes.content = item.Body.Data;
                        }
                        else if (item.MimeType == "multipart/related" || item.MimeType == "multipart/alternative")
                        {
                            foreach (var itemm in item.Parts)
                            {

                                if (itemm.MimeType == "text/html")
                                {
                                    mes.content = itemm.Body.Data;
                                }
                                else if (itemm.MimeType == "multipart/related" || itemm.MimeType == "multipart/alternative")
                                {
                                    foreach (var itemmini in itemm.Parts)
                                    {
                                        if (itemmini.MimeType == "text/html")
                                        {
                                            mes.content = itemmini.Body.Data;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    mes.content = itemmes.Payload.Body.Data;
                }
                //get content when text/html null
                if (mes.content == null)
                {
                    if (itemmes.Payload.Parts != null)
                    {
                        foreach (var item in itemmes.Payload.Parts)
                        {
                            if (item.MimeType == "text/plain")
                            {
                                mes.content = item.Body.Data;
                            }
                            else if (item.MimeType == "multipart/related" || item.MimeType == "multipart/alternative")
                            {
                                foreach (var itemm in item.Parts)
                                {

                                    if (itemm.MimeType == "text/plain")
                                    {
                                        mes.content = itemm.Body.Data;
                                    }
                                    else if (itemm.MimeType == "multipart/related" || itemm.MimeType == "multipart/alternative")
                                    {
                                        foreach (var itemmini in itemm.Parts)
                                        {
                                            if (itemmini.MimeType == "text/plain")
                                            {
                                                mes.content = itemmini.Body.Data;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        mes.content = itemmes.Payload.Body.Data;
                    }

                }


                mes.idmes = itemmes.Id;
                mesLHeader.Add(mes);
            }

            return mesLHeader;
        }

        //get message unread
        public List<MesUnread> getMesUnread(UserCredential credential)
        {
            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            //get Message id and threadid
            List<Message> resultMes = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List("me");
            request.LabelIds = "INBOX";
            request.LabelIds = "UNREAD";
            ListMessagesResponse response = request.Execute();
            resultMes.AddRange(response.Messages);
            request.PageToken = response.NextPageToken;

            //get Detail Message
            List<Message> resultDetail = new List<Message>();
            foreach (var item in resultMes)
            {
                Message mes = new Message();
                Message mesd = service.Users.Messages.Get("me", item.Id).Execute();
                mes.Snippet = mesd.Snippet;
                mes.Id = mesd.Id;
                mes.LabelIds = mesd.LabelIds;
                mes.Payload = mesd.Payload;
                resultDetail.Add(mes);
            }

            List<MesUnread> mesLHeader = new List<MesUnread>();

            foreach (Message itemmes in resultDetail)
            {
                MesUnread mes = new MesUnread();
                mes.txt3 = itemmes.Snippet;
                foreach (var item in itemmes.Payload.Headers)
                {

                    if (item.Name == "From")
                    {
                        mes.txt1 = item.Value;
                    }
                    else if (item.Name == "Subject")
                    {
                        mes.txt2 = item.Value;

                    }
                    else if (item.Name == "Date")
                    {
                        mes.txt4 = item.Value;
                    }

                }
                //get content

                if (itemmes.Payload.Parts != null)
                {
                    foreach (var item in itemmes.Payload.Parts)
                    {
                        if (item.MimeType == "text/html")
                        {
                            mes.content = item.Body.Data;
                        }
                        else if (item.MimeType == "multipart/related" || item.MimeType == "multipart/alternative")
                        {
                            foreach (var itemm in item.Parts)
                            {

                                if (itemm.MimeType == "text/html")
                                {
                                    mes.content = itemm.Body.Data;
                                }
                                else if (itemm.MimeType == "multipart/related" || itemm.MimeType == "multipart/alternative")
                                {
                                    foreach (var itemmini in itemm.Parts)
                                    {
                                        if (itemmini.MimeType == "text/html")
                                        {
                                            mes.content = itemmini.Body.Data;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    mes.content = itemmes.Payload.Body.Data;
                }
                mes.idmes = itemmes.Id;
                mesLHeader.Add(mes);
            }

            return mesLHeader;
        }

        //Mail important
        public List<MesImportant> getMesImportant(UserCredential credential)
        {
            // Create Gmail API service.
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            //get Message id and threadid
            List<Message> resultMes = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List("me");
            request.LabelIds = "INBOX";
            request.LabelIds = "IMPORTANT";
            ListMessagesResponse response = request.Execute();
            resultMes.AddRange(response.Messages);
            request.PageToken = response.NextPageToken;

            //get Detail Message
            List<Message> resultDetail = new List<Message>();
            foreach (var item in resultMes)
            {
                Message mes = new Message();
                Message mesd = service.Users.Messages.Get("me", item.Id).Execute();
                mes.Snippet = mesd.Snippet;
                mes.Id = mesd.Id;
                mes.LabelIds = mesd.LabelIds;
                mes.Payload = mesd.Payload;
                resultDetail.Add(mes);
            }

            List<MesImportant> mesLHeader = new List<MesImportant>();

            foreach (Message itemmes in resultDetail)
            {
                MesImportant mes = new MesImportant();
                mes.idimportant = itemmes.Id;
                mesLHeader.Add(mes);
            }

            return mesLHeader;
        }


    }
}
