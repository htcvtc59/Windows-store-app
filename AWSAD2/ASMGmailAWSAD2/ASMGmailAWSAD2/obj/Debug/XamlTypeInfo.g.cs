﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace ASMGmailAWSAD2
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[10];
            _typeNameTable[0] = "ASMGmailAWSAD2.MainPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "ASMGmailAWSAD2.MessageHeader";
            _typeNameTable[4] = "Windows.UI.Xaml.Visibility";
            _typeNameTable[5] = "String";
            _typeNameTable[6] = "Windows.UI.Xaml.Media.FontFamily";
            _typeNameTable[7] = "Boolean";
            _typeNameTable[8] = "Windows.UI.Xaml.Media.Brush";
            _typeNameTable[9] = "Double";

            _typeTable = new global::System.Type[10];
            _typeTable[0] = typeof(global::ASMGmailAWSAD2.MainPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::ASMGmailAWSAD2.MessageHeader);
            _typeTable[4] = typeof(global::Windows.UI.Xaml.Visibility);
            _typeTable[5] = typeof(global::System.String);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Media.FontFamily);
            _typeTable[7] = typeof(global::System.Boolean);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.Media.Brush);
            _typeTable[9] = typeof(global::System.Double);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainPage() { return new global::ASMGmailAWSAD2.MainPage(); }
        private object Activate_3_MessageHeader() { return new global::ASMGmailAWSAD2.MessageHeader(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  ASMGmailAWSAD2.MainPage
                userType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  ASMGmailAWSAD2.MessageHeader
                userType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_3_MessageHeader;
                userType.AddMemberName("tagFirstPro");
                userType.AddMemberName("tagSecondPro");
                userType.AddMemberName("txtHeader1");
                userType.AddMemberName("txtHeader1Font");
                userType.AddMemberName("txtHeader2");
                userType.AddMemberName("txtHeader2Font");
                userType.AddMemberName("txtHeader3");
                userType.AddMemberName("txtHeader3Font");
                userType.AddMemberName("txtHeader4");
                userType.AddMemberName("txtHeader4Font");
                userType.AddMemberName("txtId");
                userType.AddMemberName("txtContent");
                userType.AddMemberName("checkBoxMes");
                userType.AddMemberName("backgroundColorMes");
                userType.AddMemberName("opacityMes");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  Windows.UI.Xaml.Visibility
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  String
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Windows.UI.Xaml.Media.FontFamily
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  Boolean
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  Windows.UI.Xaml.Media.Brush
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  Double
                xamlType = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_MessageHeader_tagFirstPro(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.tagFirstPro;
        }
        private void set_0_MessageHeader_tagFirstPro(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.tagFirstPro = (global::Windows.UI.Xaml.Visibility)Value;
        }
        private object get_1_MessageHeader_tagSecondPro(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.tagSecondPro;
        }
        private void set_1_MessageHeader_tagSecondPro(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.tagSecondPro = (global::Windows.UI.Xaml.Visibility)Value;
        }
        private object get_2_MessageHeader_txtHeader1(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader1;
        }
        private void set_2_MessageHeader_txtHeader1(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader1 = (global::System.String)Value;
        }
        private object get_3_MessageHeader_txtHeader1Font(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader1Font;
        }
        private void set_3_MessageHeader_txtHeader1Font(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader1Font = (global::Windows.UI.Xaml.Media.FontFamily)Value;
        }
        private object get_4_MessageHeader_txtHeader2(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader2;
        }
        private void set_4_MessageHeader_txtHeader2(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader2 = (global::System.String)Value;
        }
        private object get_5_MessageHeader_txtHeader2Font(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader2Font;
        }
        private void set_5_MessageHeader_txtHeader2Font(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader2Font = (global::Windows.UI.Xaml.Media.FontFamily)Value;
        }
        private object get_6_MessageHeader_txtHeader3(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader3;
        }
        private void set_6_MessageHeader_txtHeader3(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader3 = (global::System.String)Value;
        }
        private object get_7_MessageHeader_txtHeader3Font(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader3Font;
        }
        private void set_7_MessageHeader_txtHeader3Font(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader3Font = (global::Windows.UI.Xaml.Media.FontFamily)Value;
        }
        private object get_8_MessageHeader_txtHeader4(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader4;
        }
        private void set_8_MessageHeader_txtHeader4(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader4 = (global::System.String)Value;
        }
        private object get_9_MessageHeader_txtHeader4Font(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtHeader4Font;
        }
        private void set_9_MessageHeader_txtHeader4Font(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtHeader4Font = (global::Windows.UI.Xaml.Media.FontFamily)Value;
        }
        private object get_10_MessageHeader_txtId(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtId;
        }
        private void set_10_MessageHeader_txtId(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtId = (global::System.String)Value;
        }
        private object get_11_MessageHeader_txtContent(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.txtContent;
        }
        private void set_11_MessageHeader_txtContent(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.txtContent = (global::System.String)Value;
        }
        private object get_12_MessageHeader_checkBoxMes(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.checkBoxMes;
        }
        private void set_12_MessageHeader_checkBoxMes(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.checkBoxMes = (global::System.Boolean)Value;
        }
        private object get_13_MessageHeader_backgroundColorMes(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.backgroundColorMes;
        }
        private void set_13_MessageHeader_backgroundColorMes(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.backgroundColorMes = (global::Windows.UI.Xaml.Media.Brush)Value;
        }
        private object get_14_MessageHeader_opacityMes(object instance)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            return that.opacityMes;
        }
        private void set_14_MessageHeader_opacityMes(object instance, object Value)
        {
            var that = (global::ASMGmailAWSAD2.MessageHeader)instance;
            that.opacityMes = (global::System.Double)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember xamlMember = null;
            global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "ASMGmailAWSAD2.MessageHeader.tagFirstPro":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "tagFirstPro", "Windows.UI.Xaml.Visibility");
                xamlMember.Getter = get_0_MessageHeader_tagFirstPro;
                xamlMember.Setter = set_0_MessageHeader_tagFirstPro;
                break;
            case "ASMGmailAWSAD2.MessageHeader.tagSecondPro":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "tagSecondPro", "Windows.UI.Xaml.Visibility");
                xamlMember.Getter = get_1_MessageHeader_tagSecondPro;
                xamlMember.Setter = set_1_MessageHeader_tagSecondPro;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader1":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader1", "String");
                xamlMember.Getter = get_2_MessageHeader_txtHeader1;
                xamlMember.Setter = set_2_MessageHeader_txtHeader1;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader1Font":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader1Font", "Windows.UI.Xaml.Media.FontFamily");
                xamlMember.Getter = get_3_MessageHeader_txtHeader1Font;
                xamlMember.Setter = set_3_MessageHeader_txtHeader1Font;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader2":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader2", "String");
                xamlMember.Getter = get_4_MessageHeader_txtHeader2;
                xamlMember.Setter = set_4_MessageHeader_txtHeader2;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader2Font":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader2Font", "Windows.UI.Xaml.Media.FontFamily");
                xamlMember.Getter = get_5_MessageHeader_txtHeader2Font;
                xamlMember.Setter = set_5_MessageHeader_txtHeader2Font;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader3":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader3", "String");
                xamlMember.Getter = get_6_MessageHeader_txtHeader3;
                xamlMember.Setter = set_6_MessageHeader_txtHeader3;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader3Font":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader3Font", "Windows.UI.Xaml.Media.FontFamily");
                xamlMember.Getter = get_7_MessageHeader_txtHeader3Font;
                xamlMember.Setter = set_7_MessageHeader_txtHeader3Font;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader4":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader4", "String");
                xamlMember.Getter = get_8_MessageHeader_txtHeader4;
                xamlMember.Setter = set_8_MessageHeader_txtHeader4;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtHeader4Font":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtHeader4Font", "Windows.UI.Xaml.Media.FontFamily");
                xamlMember.Getter = get_9_MessageHeader_txtHeader4Font;
                xamlMember.Setter = set_9_MessageHeader_txtHeader4Font;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtId":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtId", "String");
                xamlMember.Getter = get_10_MessageHeader_txtId;
                xamlMember.Setter = set_10_MessageHeader_txtId;
                break;
            case "ASMGmailAWSAD2.MessageHeader.txtContent":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "txtContent", "String");
                xamlMember.Getter = get_11_MessageHeader_txtContent;
                xamlMember.Setter = set_11_MessageHeader_txtContent;
                break;
            case "ASMGmailAWSAD2.MessageHeader.checkBoxMes":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "checkBoxMes", "Boolean");
                xamlMember.Getter = get_12_MessageHeader_checkBoxMes;
                xamlMember.Setter = set_12_MessageHeader_checkBoxMes;
                break;
            case "ASMGmailAWSAD2.MessageHeader.backgroundColorMes":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "backgroundColorMes", "Windows.UI.Xaml.Media.Brush");
                xamlMember.Getter = get_13_MessageHeader_backgroundColorMes;
                xamlMember.Setter = set_13_MessageHeader_backgroundColorMes;
                break;
            case "ASMGmailAWSAD2.MessageHeader.opacityMes":
                userType = (global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ASMGmailAWSAD2.MessageHeader");
                xamlMember = new global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlMember(this, "opacityMes", "Double");
                xamlMember.Getter = get_14_MessageHeader_opacityMes;
                xamlMember.Setter = set_14_MessageHeader_opacityMes;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlSystemBaseType
    {
        global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::ASMGmailAWSAD2.ASMGmailAWSAD2_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}









