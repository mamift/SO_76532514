

Option Strict Off
Option Explicit On

Imports System.Xml.Serialization


Namespace infofer


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class AdministrativeContactInformation


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Name As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Address As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public eMail As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public PhoneNumber As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public FaxNumber As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public FreeTextField As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code")>
    Partial Public Class CompositIdentifierOperationalType


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public ObjectType As ObjectType


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=1)>
        Public Company As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Core As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public [Variant] As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=4)>
        Public TimetableYear As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="date", Order:=5)>
        Public StartDate As Date


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public internalTrainID As Long
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum ObjectType


        TR


        PA


        CR


        PR
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlRootAttribute("AssociatedAttachedTrainID", [Namespace]:="", IsNullable:=False)>
    Partial Public Class CompositIdentifierPlannedType


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public ObjectType As ObjectType


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=1)>
        Public Company As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public Core As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public [Variant] As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=4)>
        Public TimetableYear As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="date", Order:=5)>
        Public StartDate As Date


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public StartDateSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public internalTrainID As Long
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum BrakeType


        G


        P


        R


        M
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum TypeOfInformation


        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1


        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2


        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3


        <System.Xml.Serialization.XmlEnumAttribute("4")>
        Item4


        <System.Xml.Serialization.XmlEnumAttribute("5")>
        Item5


        <System.Xml.Serialization.XmlEnumAttribute("6")>
        Item6


        <System.Xml.Serialization.XmlEnumAttribute("7")>
        Item7


        <System.Xml.Serialization.XmlEnumAttribute("8")>
        Item8
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Recipient


        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="integer")>
        Public CI_InstanceNumber As String


        <System.Xml.Serialization.XmlTextAttribute(DataType:="integer")>
        Public Value As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class CFRTrainInfo


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Indicativ As Long


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public IndicativSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public TrainHeader As Long


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public TrainHeaderSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>
        Public VitezaMaxima As Integer


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public VitezaMaximaSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public ProcentFranare As Integer


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ProcentFranareSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=4)>
        Public MersTren As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=5)>
        Public DataProgramata As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=6)>
        Public Mentiuni As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public Observatii As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum CharacteristicDescriptionCode


        <System.Xml.Serialization.XmlEnumAttribute("6")>
        Item6


        <System.Xml.Serialization.XmlEnumAttribute("7")>
        Item7


        <System.Xml.Serialization.XmlEnumAttribute("11")>
        Item11


        <System.Xml.Serialization.XmlEnumAttribute("12")>
        Item12


        <System.Xml.Serialization.XmlEnumAttribute("13")>
        Item13


        <System.Xml.Serialization.XmlEnumAttribute("14")>
        Item14


        <System.Xml.Serialization.XmlEnumAttribute("15")>
        Item15


        <System.Xml.Serialization.XmlEnumAttribute("16")>
        Item16


        <System.Xml.Serialization.XmlEnumAttribute("17")>
        Item17


        <System.Xml.Serialization.XmlEnumAttribute("18")>
        Item18


        <System.Xml.Serialization.XmlEnumAttribute("19")>
        Item19


        <System.Xml.Serialization.XmlEnumAttribute("20")>
        Item20


        <System.Xml.Serialization.XmlEnumAttribute("21")>
        Item21


        <System.Xml.Serialization.XmlEnumAttribute("22")>
        Item22


        <System.Xml.Serialization.XmlEnumAttribute("23")>
        Item23


        <System.Xml.Serialization.XmlEnumAttribute("24")>
        Item24


        <System.Xml.Serialization.XmlEnumAttribute("25")>
        Item25


        <System.Xml.Serialization.XmlEnumAttribute("26")>
        Item26


        <System.Xml.Serialization.XmlEnumAttribute("27")>
        Item27


        <System.Xml.Serialization.XmlEnumAttribute("28")>
        Item28
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum CommercialTrafficType


        <System.Xml.Serialization.XmlEnumAttribute("46")>
        Item46


        <System.Xml.Serialization.XmlEnumAttribute("47")>
        Item47


        <System.Xml.Serialization.XmlEnumAttribute("48")>
        Item48


        <System.Xml.Serialization.XmlEnumAttribute("49")>
        Item49


        <System.Xml.Serialization.XmlEnumAttribute("50")>
        Item50


        <System.Xml.Serialization.XmlEnumAttribute("51")>
        Item51


        <System.Xml.Serialization.XmlEnumAttribute("52")>
        Item52


        <System.Xml.Serialization.XmlEnumAttribute("53")>
        Item53


        <System.Xml.Serialization.XmlEnumAttribute("54")>
        Item54


        <System.Xml.Serialization.XmlEnumAttribute("62")>
        Item62


        <System.Xml.Serialization.XmlEnumAttribute("63")>
        Item63


        <System.Xml.Serialization.XmlEnumAttribute("64")>
        Item64


        <System.Xml.Serialization.XmlEnumAttribute("65")>
        Item65


        <System.Xml.Serialization.XmlEnumAttribute("66")>
        Item66


        <System.Xml.Serialization.XmlEnumAttribute("67")>
        Item67


        <System.Xml.Serialization.XmlEnumAttribute("68")>
        Item68


        <System.Xml.Serialization.XmlEnumAttribute("69")>
        Item69


        <System.Xml.Serialization.XmlEnumAttribute("70")>
        Item70


        <System.Xml.Serialization.XmlEnumAttribute("71")>
        Item71


        <System.Xml.Serialization.XmlEnumAttribute("72")>
        Item72


        <System.Xml.Serialization.XmlEnumAttribute("73")>
        Item73


        <System.Xml.Serialization.XmlEnumAttribute("74")>
        Item74


        <System.Xml.Serialization.XmlEnumAttribute("75")>
        Item75


        <System.Xml.Serialization.XmlEnumAttribute("76")>
        Item76


        <System.Xml.Serialization.XmlEnumAttribute("77")>
        Item77


        <System.Xml.Serialization.XmlEnumAttribute("78")>
        Item78


        <System.Xml.Serialization.XmlEnumAttribute("79")>
        Item79


        <System.Xml.Serialization.XmlEnumAttribute("80")>
        Item80


        <System.Xml.Serialization.XmlEnumAttribute("82")>
        Item82


        <System.Xml.Serialization.XmlEnumAttribute("83")>
        Item83


        <System.Xml.Serialization.XmlEnumAttribute("84")>
        Item84


        <System.Xml.Serialization.XmlEnumAttribute("85")>
        Item85


        <System.Xml.Serialization.XmlEnumAttribute("86")>
        Item86


        <System.Xml.Serialization.XmlEnumAttribute("87")>
        Item87


        <System.Xml.Serialization.XmlEnumAttribute("88")>
        Item88


        <System.Xml.Serialization.XmlEnumAttribute("89")>
        Item89


        <System.Xml.Serialization.XmlEnumAttribute("90")>
        Item90


        <System.Xml.Serialization.XmlEnumAttribute("91")>
        Item91


        <System.Xml.Serialization.XmlEnumAttribute("92")>
        Item92


        <System.Xml.Serialization.XmlEnumAttribute("93")>
        Item93


        <System.Xml.Serialization.XmlEnumAttribute("94")>
        Item94


        <System.Xml.Serialization.XmlEnumAttribute("96")>
        Item96


        <System.Xml.Serialization.XmlEnumAttribute("97")>
        Item97


        <System.Xml.Serialization.XmlEnumAttribute("98")>
        Item98


        <System.Xml.Serialization.XmlEnumAttribute("99")>
        Item99


        <System.Xml.Serialization.XmlEnumAttribute("100")>
        Item100


        <System.Xml.Serialization.XmlEnumAttribute("101")>
        Item101


        <System.Xml.Serialization.XmlEnumAttribute("102")>
        Item102


        <System.Xml.Serialization.XmlEnumAttribute("104")>
        Item104


        <System.Xml.Serialization.XmlEnumAttribute("105")>
        Item105


        <System.Xml.Serialization.XmlEnumAttribute("107")>
        Item107


        <System.Xml.Serialization.XmlEnumAttribute("108")>
        Item108


        <System.Xml.Serialization.XmlEnumAttribute("109")>
        Item109


        <System.Xml.Serialization.XmlEnumAttribute("110")>
        Item110


        <System.Xml.Serialization.XmlEnumAttribute("111")>
        Item111


        <System.Xml.Serialization.XmlEnumAttribute("112")>
        Item112


        <System.Xml.Serialization.XmlEnumAttribute("113")>
        Item113


        <System.Xml.Serialization.XmlEnumAttribute("114")>
        Item114


        <System.Xml.Serialization.XmlEnumAttribute("115")>
        Item115


        <System.Xml.Serialization.XmlEnumAttribute("116")>
        Item116


        <System.Xml.Serialization.XmlEnumAttribute("117")>
        Item117


        <System.Xml.Serialization.XmlEnumAttribute("118")>
        Item118


        <System.Xml.Serialization.XmlEnumAttribute("119")>
        Item119


        <System.Xml.Serialization.XmlEnumAttribute("120")>
        Item120


        <System.Xml.Serialization.XmlEnumAttribute("121")>
        Item121


        <System.Xml.Serialization.XmlEnumAttribute("122")>
        Item122


        <System.Xml.Serialization.XmlEnumAttribute("123")>
        Item123


        <System.Xml.Serialization.XmlEnumAttribute("126")>
        Item126


        <System.Xml.Serialization.XmlEnumAttribute("127")>
        Item127


        <System.Xml.Serialization.XmlEnumAttribute("128")>
        Item128


        <System.Xml.Serialization.XmlEnumAttribute("129")>
        Item129


        <System.Xml.Serialization.XmlEnumAttribute("153")>
        Item153


        <System.Xml.Serialization.XmlEnumAttribute("154")>
        Item154


        <System.Xml.Serialization.XmlEnumAttribute("155")>
        Item155


        <System.Xml.Serialization.XmlEnumAttribute("157")>
        Item157


        <System.Xml.Serialization.XmlEnumAttribute("158")>
        Item158


        <System.Xml.Serialization.XmlEnumAttribute("159")>
        Item159


        <System.Xml.Serialization.XmlEnumAttribute("160")>
        Item160


        <System.Xml.Serialization.XmlEnumAttribute("161")>
        Item161


        <System.Xml.Serialization.XmlEnumAttribute("162")>
        Item162


        <System.Xml.Serialization.XmlEnumAttribute("163")>
        Item163


        <System.Xml.Serialization.XmlEnumAttribute("164")>
        Item164


        <System.Xml.Serialization.XmlEnumAttribute("165")>
        Item165


        <System.Xml.Serialization.XmlEnumAttribute("170")>
        Item170


        <System.Xml.Serialization.XmlEnumAttribute("171")>
        Item171


        <System.Xml.Serialization.XmlEnumAttribute("172")>
        Item172


        <System.Xml.Serialization.XmlEnumAttribute("173")>
        Item173


        <System.Xml.Serialization.XmlEnumAttribute("174")>
        Item174


        <System.Xml.Serialization.XmlEnumAttribute("175")>
        Item175


        <System.Xml.Serialization.XmlEnumAttribute("176")>
        Item176


        <System.Xml.Serialization.XmlEnumAttribute("200")>
        Item200


        <System.Xml.Serialization.XmlEnumAttribute("202")>
        Item202


        <System.Xml.Serialization.XmlEnumAttribute("203")>
        Item203


        <System.Xml.Serialization.XmlEnumAttribute("204")>
        Item204


        <System.Xml.Serialization.XmlEnumAttribute("205")>
        Item205


        <System.Xml.Serialization.XmlEnumAttribute("206")>
        Item206


        <System.Xml.Serialization.XmlEnumAttribute("207")>
        Item207


        <System.Xml.Serialization.XmlEnumAttribute("208")>
        Item208


        <System.Xml.Serialization.XmlEnumAttribute("209")>
        Item209


        <System.Xml.Serialization.XmlEnumAttribute("210")>
        Item210


        <System.Xml.Serialization.XmlEnumAttribute("212")>
        Item212


        <System.Xml.Serialization.XmlEnumAttribute("213")>
        Item213


        <System.Xml.Serialization.XmlEnumAttribute("214")>
        Item214


        <System.Xml.Serialization.XmlEnumAttribute("215")>
        Item215


        <System.Xml.Serialization.XmlEnumAttribute("216")>
        Item216


        <System.Xml.Serialization.XmlEnumAttribute("219")>
        Item219


        <System.Xml.Serialization.XmlEnumAttribute("222")>
        Item222
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class CombinedTrafficLoadProfile


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer", Order:=0)>
        Public P1 As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer", Order:=1)>
        Public P2 As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer", Order:=2)>
        Public C1 As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer", Order:=3)>
        Public C2 As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum DangerLabel


        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1


        <System.Xml.Serialization.XmlEnumAttribute("1.4")>
        Item14


        <System.Xml.Serialization.XmlEnumAttribute("1.5")>
        Item15


        <System.Xml.Serialization.XmlEnumAttribute("1.6")>
        Item16


        <System.Xml.Serialization.XmlEnumAttribute("2.1")>
        Item21


        <System.Xml.Serialization.XmlEnumAttribute("2.2")>
        Item22


        <System.Xml.Serialization.XmlEnumAttribute("2.3")>
        Item23


        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3


        <System.Xml.Serialization.XmlEnumAttribute("4.1")>
        Item41


        <System.Xml.Serialization.XmlEnumAttribute("4.2")>
        Item42


        <System.Xml.Serialization.XmlEnumAttribute("4.3")>
        Item43


        <System.Xml.Serialization.XmlEnumAttribute("5.1")>
        Item51


        <System.Xml.Serialization.XmlEnumAttribute("5.2")>
        Item52


        <System.Xml.Serialization.XmlEnumAttribute("6.1")>
        Item61


        <System.Xml.Serialization.XmlEnumAttribute("6.2")>
        Item62


        <System.Xml.Serialization.XmlEnumAttribute("7D")>
        Item7D


        <System.Xml.Serialization.XmlEnumAttribute("8")>
        Item8


        <System.Xml.Serialization.XmlEnumAttribute("9")>
        Item9
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlRootAttribute("DangerousGoodsIndication", [Namespace]:="", IsNullable:=False)>
    Partial Public Class DanGoodsType


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public HazardIdentificationNumber As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public UN_Number As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public DangerLabel As DangerLabel


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public DangerLabelSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public RID_Class As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="token", Order:=4)>
        Public PackingGroup As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=5)>
        Public DangerousGoodsWeight As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public DangerousGoodsVolume As Single


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public DangerousGoodsVolumeSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=7)>
        Public LimitedQuantityIndicator As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class DelayCauseTime


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public DelayCause As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public DelayMinutes As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public DelayEventDateTime As Date


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public InternalReferenceIdentifier As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public DelayCodingDateTime As Date


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public DelayCodingDateTimeSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Remarks As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class DelayEventReport


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public DelayLocation As LocationIdent


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public TrainLocationStatus As RunningStatus


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public DelayCauseTime As DelayCauseTime
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlRootAttribute("DelayLocation", [Namespace]:="", IsNullable:=False)>
    Partial Public Class LocationIdent


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public CountryCodeISO As CountryCodeISO


        <System.Xml.Serialization.XmlElementAttribute(DataType:="positiveInteger", Order:=1)>
        Public LocationPrimaryCode As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public PrimaryLocationName As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public LocationSubsidiaryIdentification As LocationSubsidiaryIdentification
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class CountryCodeISO


        <System.Xml.Serialization.XmlTextAttribute()>
        Public Value As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class LocationSubsidiaryIdentification


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public LocationSubsidiaryCode As LocationSubsidiaryCode


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=1)>
        Public AllocationCompany As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public LocationSubsidiaryName As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class LocationSubsidiaryCode


        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public LocationSubsidiaryTypeCode As LocationSubsidiaryCodeLocationSubsidiaryTypeCode


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public LocationSubsidiaryTypeCodeSpecified As Boolean


        <System.Xml.Serialization.XmlTextAttribute()>
        Public Value As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum LocationSubsidiaryCodeLocationSubsidiaryTypeCode


        <System.Xml.Serialization.XmlEnumAttribute("0")>
        Item0


        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1


        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2


        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3


        <System.Xml.Serialization.XmlEnumAttribute("4")>
        Item4


        <System.Xml.Serialization.XmlEnumAttribute("5")>
        Item5


        <System.Xml.Serialization.XmlEnumAttribute("6")>
        Item6


        <System.Xml.Serialization.XmlEnumAttribute("7")>
        Item7


        <System.Xml.Serialization.XmlEnumAttribute("8")>
        Item8


        <System.Xml.Serialization.XmlEnumAttribute("9")>
        Item9


        <System.Xml.Serialization.XmlEnumAttribute("10")>
        Item10


        <System.Xml.Serialization.XmlEnumAttribute("11")>
        Item11


        <System.Xml.Serialization.XmlEnumAttribute("12")>
        Item12


        <System.Xml.Serialization.XmlEnumAttribute("13")>
        Item13


        <System.Xml.Serialization.XmlEnumAttribute("14")>
        Item14


        <System.Xml.Serialization.XmlEnumAttribute("15")>
        Item15


        <System.Xml.Serialization.XmlEnumAttribute("16")>
        Item16


        <System.Xml.Serialization.XmlEnumAttribute("17")>
        Item17


        <System.Xml.Serialization.XmlEnumAttribute("18")>
        Item18


        <System.Xml.Serialization.XmlEnumAttribute("19")>
        Item19


        <System.Xml.Serialization.XmlEnumAttribute("20")>
        Item20


        <System.Xml.Serialization.XmlEnumAttribute("21")>
        Item21


        <System.Xml.Serialization.XmlEnumAttribute("22")>
        Item22


        <System.Xml.Serialization.XmlEnumAttribute("23")>
        Item23


        <System.Xml.Serialization.XmlEnumAttribute("24")>
        Item24


        <System.Xml.Serialization.XmlEnumAttribute("25")>
        Item25


        <System.Xml.Serialization.XmlEnumAttribute("26")>
        Item26


        <System.Xml.Serialization.XmlEnumAttribute("27")>
        Item27


        <System.Xml.Serialization.XmlEnumAttribute("28")>
        Item28


        <System.Xml.Serialization.XmlEnumAttribute("29")>
        Item29


        <System.Xml.Serialization.XmlEnumAttribute("30")>
        Item30


        <System.Xml.Serialization.XmlEnumAttribute("32")>
        Item32


        <System.Xml.Serialization.XmlEnumAttribute("33")>
        Item33


        <System.Xml.Serialization.XmlEnumAttribute("34")>
        Item34


        <System.Xml.Serialization.XmlEnumAttribute("35")>
        Item35


        <System.Xml.Serialization.XmlEnumAttribute("36")>
        Item36


        <System.Xml.Serialization.XmlEnumAttribute("37")>
        Item37


        <System.Xml.Serialization.XmlEnumAttribute("38")>
        Item38


        <System.Xml.Serialization.XmlEnumAttribute("39")>
        Item39


        <System.Xml.Serialization.XmlEnumAttribute("40")>
        Item40


        <System.Xml.Serialization.XmlEnumAttribute("41")>
        Item41


        <System.Xml.Serialization.XmlEnumAttribute("90")>
        Item90


        <System.Xml.Serialization.XmlEnumAttribute("99")>
        Item99
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlRootAttribute("TrainLocationStatus", [Namespace]:="", IsNullable:=False)>
    Public Enum RunningStatus


        <System.Xml.Serialization.XmlEnumAttribute("00")>
        Item00


        <System.Xml.Serialization.XmlEnumAttribute("01")>
        Item01


        <System.Xml.Serialization.XmlEnumAttribute("02")>
        Item02


        <System.Xml.Serialization.XmlEnumAttribute("03")>
        Item03


        <System.Xml.Serialization.XmlEnumAttribute("04")>
        Item04


        <System.Xml.Serialization.XmlEnumAttribute("05")>
        Item05


        <System.Xml.Serialization.XmlEnumAttribute("06")>
        Item06


        <System.Xml.Serialization.XmlEnumAttribute("07")>
        Item07


        <System.Xml.Serialization.XmlEnumAttribute("08")>
        Item08


        <System.Xml.Serialization.XmlEnumAttribute("09")>
        Item09


        <System.Xml.Serialization.XmlEnumAttribute("10")>
        Item10


        <System.Xml.Serialization.XmlEnumAttribute("11")>
        Item11


        <System.Xml.Serialization.XmlEnumAttribute("12")>
        Item12


        <System.Xml.Serialization.XmlEnumAttribute("13")>
        Item13


        <System.Xml.Serialization.XmlEnumAttribute("14")>
        Item14


        <System.Xml.Serialization.XmlEnumAttribute("15")>
        Item15


        <System.Xml.Serialization.XmlEnumAttribute("16")>
        Item16


        <System.Xml.Serialization.XmlEnumAttribute("17")>
        Item17


        <System.Xml.Serialization.XmlEnumAttribute("18")>
        Item18


        <System.Xml.Serialization.XmlEnumAttribute("19")>
        Item19
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class ExceptionalGaugingIdent


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=0)>
        Public IM_Partner As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public ExceptionalGaugingCode As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum FacilityTypeDescriptionCode


        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2


        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3


        <System.Xml.Serialization.XmlEnumAttribute("4")>
        Item4


        <System.Xml.Serialization.XmlEnumAttribute("5")>
        Item5


        <System.Xml.Serialization.XmlEnumAttribute("6")>
        Item6


        <System.Xml.Serialization.XmlEnumAttribute("7")>
        Item7


        <System.Xml.Serialization.XmlEnumAttribute("8")>
        Item8


        <System.Xml.Serialization.XmlEnumAttribute("9")>
        Item9


        <System.Xml.Serialization.XmlEnumAttribute("11")>
        Item11


        <System.Xml.Serialization.XmlEnumAttribute("12")>
        Item12


        <System.Xml.Serialization.XmlEnumAttribute("13")>
        Item13


        <System.Xml.Serialization.XmlEnumAttribute("14")>
        Item14


        <System.Xml.Serialization.XmlEnumAttribute("15")>
        Item15


        <System.Xml.Serialization.XmlEnumAttribute("16")>
        Item16


        <System.Xml.Serialization.XmlEnumAttribute("17")>
        Item17


        <System.Xml.Serialization.XmlEnumAttribute("18")>
        Item18


        <System.Xml.Serialization.XmlEnumAttribute("19")>
        Item19


        <System.Xml.Serialization.XmlEnumAttribute("20")>
        Item20


        <System.Xml.Serialization.XmlEnumAttribute("21")>
        Item21


        <System.Xml.Serialization.XmlEnumAttribute("24")>
        Item24


        <System.Xml.Serialization.XmlEnumAttribute("26")>
        Item26


        <System.Xml.Serialization.XmlEnumAttribute("28")>
        Item28


        <System.Xml.Serialization.XmlEnumAttribute("33")>
        Item33


        <System.Xml.Serialization.XmlEnumAttribute("34")>
        Item34


        <System.Xml.Serialization.XmlEnumAttribute("36")>
        Item36


        <System.Xml.Serialization.XmlEnumAttribute("44")>
        Item44


        <System.Xml.Serialization.XmlEnumAttribute("45")>
        Item45


        <System.Xml.Serialization.XmlEnumAttribute("46")>
        Item46


        <System.Xml.Serialization.XmlEnumAttribute("47")>
        Item47


        <System.Xml.Serialization.XmlEnumAttribute("48")>
        Item48


        <System.Xml.Serialization.XmlEnumAttribute("50")>
        Item50


        <System.Xml.Serialization.XmlEnumAttribute("54")>
        Item54


        <System.Xml.Serialization.XmlEnumAttribute("55")>
        Item55


        <System.Xml.Serialization.XmlEnumAttribute("56")>
        Item56


        <System.Xml.Serialization.XmlEnumAttribute("57")>
        Item57


        <System.Xml.Serialization.XmlEnumAttribute("58")>
        Item58


        <System.Xml.Serialization.XmlEnumAttribute("59")>
        Item59


        <System.Xml.Serialization.XmlEnumAttribute("60")>
        Item60


        <System.Xml.Serialization.XmlEnumAttribute("61")>
        Item61


        <System.Xml.Serialization.XmlEnumAttribute("62")>
        Item62


        <System.Xml.Serialization.XmlEnumAttribute("63")>
        Item63


        <System.Xml.Serialization.XmlEnumAttribute("64")>
        Item64


        <System.Xml.Serialization.XmlEnumAttribute("65")>
        Item65


        <System.Xml.Serialization.XmlEnumAttribute("101")>
        Item101


        <System.Xml.Serialization.XmlEnumAttribute("102")>
        Item102


        <System.Xml.Serialization.XmlEnumAttribute("103")>
        Item103


        <System.Xml.Serialization.XmlEnumAttribute("104")>
        Item104


        <System.Xml.Serialization.XmlEnumAttribute("105")>
        Item105
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Identifiers


        <System.Xml.Serialization.XmlElementAttribute("PlannedTransportIdentifiers", Order:=0)>
        Public PlannedTransportIdentifiers() As CompositIdentifierPlannedType


        <System.Xml.Serialization.XmlElementAttribute("RelatedPlannedTransportIdentifiers", Order:=1)>
        Public RelatedPlannedTransportIdentifiers() As CompositIdentifierPlannedType
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum MessageType


        <System.Xml.Serialization.XmlEnumAttribute("2001")>
        Item2001


        <System.Xml.Serialization.XmlEnumAttribute("2002")>
        Item2002


        <System.Xml.Serialization.XmlEnumAttribute("2003")>
        Item2003


        <System.Xml.Serialization.XmlEnumAttribute("2004")>
        Item2004


        <System.Xml.Serialization.XmlEnumAttribute("2005")>
        Item2005


        <System.Xml.Serialization.XmlEnumAttribute("2006")>
        Item2006


        <System.Xml.Serialization.XmlEnumAttribute("2007")>
        Item2007


        <System.Xml.Serialization.XmlEnumAttribute("3001")>
        Item3001


        <System.Xml.Serialization.XmlEnumAttribute("3002")>
        Item3002


        <System.Xml.Serialization.XmlEnumAttribute("3003")>
        Item3003


        <System.Xml.Serialization.XmlEnumAttribute("3004")>
        Item3004


        <System.Xml.Serialization.XmlEnumAttribute("3005")>
        Item3005


        <System.Xml.Serialization.XmlEnumAttribute("3006")>
        Item3006


        <System.Xml.Serialization.XmlEnumAttribute("4001")>
        Item4001


        <System.Xml.Serialization.XmlEnumAttribute("4002")>
        Item4002


        <System.Xml.Serialization.XmlEnumAttribute("4003")>
        Item4003


        <System.Xml.Serialization.XmlEnumAttribute("4004")>
        Item4004


        <System.Xml.Serialization.XmlEnumAttribute("4005")>
        Item4005


        <System.Xml.Serialization.XmlEnumAttribute("4006")>
        Item4006


        <System.Xml.Serialization.XmlEnumAttribute("5001")>
        Item5001


        <System.Xml.Serialization.XmlEnumAttribute("5002")>
        Item5002


        <System.Xml.Serialization.XmlEnumAttribute("5003")>
        Item5003


        <System.Xml.Serialization.XmlEnumAttribute("5004")>
        Item5004


        <System.Xml.Serialization.XmlEnumAttribute("5005")>
        Item5005


        <System.Xml.Serialization.XmlEnumAttribute("5006")>
        Item5006


        <System.Xml.Serialization.XmlEnumAttribute("5007")>
        Item5007


        <System.Xml.Serialization.XmlEnumAttribute("5008")>
        Item5008


        <System.Xml.Serialization.XmlEnumAttribute("5009")>
        Item5009


        <System.Xml.Serialization.XmlEnumAttribute("5010")>
        Item5010


        <System.Xml.Serialization.XmlEnumAttribute("5011")>
        Item5011


        <System.Xml.Serialization.XmlEnumAttribute("5012")>
        Item5012


        <System.Xml.Serialization.XmlEnumAttribute("5013")>
        Item5013


        <System.Xml.Serialization.XmlEnumAttribute("5014")>
        Item5014


        <System.Xml.Serialization.XmlEnumAttribute("5015")>
        Item5015


        <System.Xml.Serialization.XmlEnumAttribute("5016")>
        Item5016


        <System.Xml.Serialization.XmlEnumAttribute("6001")>
        Item6001


        <System.Xml.Serialization.XmlEnumAttribute("6002")>
        Item6002


        <System.Xml.Serialization.XmlEnumAttribute("6003")>
        Item6003
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum Measure


        ft


        mm
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class MessageHeader


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public MessageReference As MessageReference


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=1)>
        Public MessageRoutingID As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public SenderReference As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public Sender As Sender


        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Recipient As Recipient
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class MessageReference


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public MessageType As MessageType


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public MessageTypeVersion As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public MessageIdentifier As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=3)>
        Public MessageDateTime As Date


        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public Source As Source
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum Source


        R7


        R8


        TIS2002


        R100


        R3


        R2


        R12
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Sender


        <System.Xml.Serialization.XmlAttributeAttribute(DataType:="integer")>
        Public CI_InstanceNumber As String


        <System.Xml.Serialization.XmlTextAttribute(DataType:="integer")>
        Public Value As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum MessageStatus


        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1


        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2


        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class NetworkSpecificParameter


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Name As String


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public Value As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class OperationalTrainNumberIdentifier


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public OperationalTrainNumber As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public ScheduledTimeAtHandover As Date


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ScheduledTimeAtHandoverSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public ScheduledDateTimeAtTransfer As Date


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ScheduledDateTimeAtTransferSpecified As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum RouteClass


        A


        B


        C2


        C4


        D2


        D4


        A2


        A4


        B1


        B2


        C3


        D3


        E4


        E5


        D4xL
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class ReferenceOTN


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public OperationalTrainNumberIdentifier As OperationalTrainNumberIdentifier
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum SpecialServiceDescriptionCode


        <System.Xml.Serialization.XmlEnumAttribute("3")>
        Item3


        <System.Xml.Serialization.XmlEnumAttribute("4")>
        Item4


        <System.Xml.Serialization.XmlEnumAttribute("5")>
        Item5


        <System.Xml.Serialization.XmlEnumAttribute("6")>
        Item6


        <System.Xml.Serialization.XmlEnumAttribute("7")>
        Item7


        <System.Xml.Serialization.XmlEnumAttribute("8")>
        Item8


        <System.Xml.Serialization.XmlEnumAttribute("9")>
        Item9


        <System.Xml.Serialization.XmlEnumAttribute("11")>
        Item11


        <System.Xml.Serialization.XmlEnumAttribute("21")>
        Item21


        <System.Xml.Serialization.XmlEnumAttribute("22")>
        Item22


        <System.Xml.Serialization.XmlEnumAttribute("23")>
        Item23


        <System.Xml.Serialization.XmlEnumAttribute("24")>
        Item24


        <System.Xml.Serialization.XmlEnumAttribute("25")>
        Item25


        <System.Xml.Serialization.XmlEnumAttribute("26")>
        Item26


        <System.Xml.Serialization.XmlEnumAttribute("27")>
        Item27


        <System.Xml.Serialization.XmlEnumAttribute("28")>
        Item28


        <System.Xml.Serialization.XmlEnumAttribute("29")>
        Item29


        <System.Xml.Serialization.XmlEnumAttribute("30")>
        Item30


        <System.Xml.Serialization.XmlEnumAttribute("31")>
        Item31


        <System.Xml.Serialization.XmlEnumAttribute("32")>
        Item32


        <System.Xml.Serialization.XmlEnumAttribute("33")>
        Item33


        <System.Xml.Serialization.XmlEnumAttribute("34")>
        Item34


        <System.Xml.Serialization.XmlEnumAttribute("35")>
        Item35


        <System.Xml.Serialization.XmlEnumAttribute("36")>
        Item36


        <System.Xml.Serialization.XmlEnumAttribute("37")>
        Item37


        <System.Xml.Serialization.XmlEnumAttribute("38")>
        Item38


        <System.Xml.Serialization.XmlEnumAttribute("39")>
        Item39


        <System.Xml.Serialization.XmlEnumAttribute("40")>
        Item40


        <System.Xml.Serialization.XmlEnumAttribute("41")>
        Item41


        <System.Xml.Serialization.XmlEnumAttribute("42")>
        Item42


        <System.Xml.Serialization.XmlEnumAttribute("43")>
        Item43


        <System.Xml.Serialization.XmlEnumAttribute("44")>
        Item44


        <System.Xml.Serialization.XmlEnumAttribute("45")>
        Item45
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PlannedCalendar


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public BitmapDays As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public ValidityPeriod As ValidityPeriod
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class ValidityPeriod


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public StartDateTime As Date


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public EndDateTime As Date


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public EndDateTimeSpecified As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=True)>
    Partial Public Class PlannedTrainData


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public TrainType As TrainType


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public TrainTypeSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public TrafficType As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public TypeofService As TypeofService


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public CommercialTrafficType As CommercialTrafficType


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public CommercialTrafficTypeSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public PlannedTrainTechnicalData As PlannedTrainTechnicalData


        <System.Xml.Serialization.XmlElementAttribute("ExceptionalGaugingIdent", Order:=5)>
        Public ExceptionalGaugingIdent() As ExceptionalGaugingIdent


        <System.Xml.Serialization.XmlElementAttribute("DangerousGoodsIndication", Order:=6)>
        Public DangerousGoodsIndication() As DanGoodsType


        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public CombinedTrafficLoadProfile As CombinedTrafficLoadProfile
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum TrainType


        <System.Xml.Serialization.XmlEnumAttribute("01")>
        Item01


        <System.Xml.Serialization.XmlEnumAttribute("02")>
        Item02


        <System.Xml.Serialization.XmlEnumAttribute("03")>
        Item03


        <System.Xml.Serialization.XmlEnumAttribute("04")>
        Item04


        <System.Xml.Serialization.XmlEnumAttribute("00")>
        Item00
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class TypeofService


        <System.Xml.Serialization.XmlElementAttribute("SpecialServiceDescriptionCode", Order:=0)>
        Public SpecialServiceDescriptionCode() As SpecialServiceDescriptionCode


        <System.Xml.Serialization.XmlElementAttribute("FacilityTypeDescriptionCode", Order:=1)>
        Public FacilityTypeDescriptionCode() As FacilityTypeDescriptionCode


        <System.Xml.Serialization.XmlElementAttribute("CharacteristicDescriptionCode", Order:=2)>
        Public CharacteristicDescriptionCode() As CharacteristicDescriptionCode
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PlannedTrainTechnicalData


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public TrainWeight As Integer


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=1)>
        Public TrainLength As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public WeightOfSetOfCarriages As Integer


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public WeightOfSetOfCarriagesSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=3)>
        Public LengthOfSetOfCarriages As String


        <System.Xml.Serialization.XmlElementAttribute("TractionDetails", Order:=4)>
        Public TractionDetails() As TractionDetails


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=5)>
        Public TrainMaxSpeed As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=6)>
        Public HighestPlannedSpeed As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=7)>
        Public MaxAxleWeight As Integer


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public MaxAxleWeightSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public RouteClass As RouteClass


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public RouteClassSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public BrakeType As BrakeType


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public BrakeTypeSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public EmergencyBrakeOverride As Boolean


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public EmergencyBrakeOverrideSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=11)>
        Public BrakingRatio As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=12)>
        Public MinBrakedWeightPercent As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=13)>
        Public BrakeWeight As Integer


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public BrakeWeightSpecified As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class TractionDetails


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public LocoTypeNumber As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=1)>
        Public TractionMode As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public TrainCC_System As TrainCC_Syst


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public TrainCC_SystemSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public TrainRadioSystem As TrainRadioSystem


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public TrainRadioSystemSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public TractionWeight As Integer


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public TractionWeightSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public Length As Length
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlRootAttribute("TrainCC_System", [Namespace]:="", IsNullable:=False)>
    Public Enum TrainCC_Syst


        <System.Xml.Serialization.XmlEnumAttribute("01")>
        Item01


        <System.Xml.Serialization.XmlEnumAttribute("02")>
        Item02


        <System.Xml.Serialization.XmlEnumAttribute("03")>
        Item03


        <System.Xml.Serialization.XmlEnumAttribute("04")>
        Item04


        <System.Xml.Serialization.XmlEnumAttribute("05")>
        Item05


        <System.Xml.Serialization.XmlEnumAttribute("06")>
        Item06


        <System.Xml.Serialization.XmlEnumAttribute("11")>
        Item11


        <System.Xml.Serialization.XmlEnumAttribute("12")>
        Item12


        <System.Xml.Serialization.XmlEnumAttribute("21")>
        Item21


        <System.Xml.Serialization.XmlEnumAttribute("22")>
        Item22


        <System.Xml.Serialization.XmlEnumAttribute("23")>
        Item23


        <System.Xml.Serialization.XmlEnumAttribute("31")>
        Item31
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum TrainRadioSystem


        <System.Xml.Serialization.XmlEnumAttribute("1")>
        Item1


        <System.Xml.Serialization.XmlEnumAttribute("2")>
        Item2
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class Length


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Value As Decimal


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public Measure As Measure
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class PlannedJourneyLocation
        Inherits LocationIdent


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public TimingAtLocation As TimingAtLocation


        <System.Xml.Serialization.XmlElementAttribute("FreeTextField", Order:=1)>
        Public FreeTextField() As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=2)>
        Public ResponsibleApplicant As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=3)>
        Public ResponsibleRU As String


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=4)>
        Public ResponsibleIM As String


        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=True, Order:=5)>
        Public PlannedTrainData As PlannedTrainData


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=6)>
        Public StatusOfHarmonization As PlannedJourneyLocationStatusOfHarmonization


        <System.Xml.Serialization.XmlElementAttribute("TrainActivity", Order:=7)>
        Public TrainActivity() As TrainActivityType


        <System.Xml.Serialization.XmlElementAttribute(Order:=8)>
        Public OnDemandPath As Boolean


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public OnDemandPathSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=9)>
        Public PreArrangedPath As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=10)>
        Public OperationalTrainNumber As String


        <System.Xml.Serialization.XmlElementAttribute("NetworkSpecificParameter", Order:=11)>
        Public NetworkSpecificParameter() As NetworkSpecificParameter


        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public JourneyLocationTypeCode As PlannedJourneyLocationJourneyLocationTypeCode


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public JourneyLocationTypeCodeSpecified As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class TimingAtLocation


        <System.Xml.Serialization.XmlElementAttribute("Timing", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Timing() As TimingAtLocationTiming


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public DwellTime As Decimal


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public DwellTimeSpecified As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class TimingAtLocationTiming


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public Time As Date


        <System.Xml.Serialization.XmlElementAttribute(DataType:="integer", Order:=1)>
        Public Offset As String


        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public TimingQualifierCode As TimingAtLocationTimingTimingQualifierCode


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public TimingQualifierCodeSpecified As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum TimingAtLocationTimingTimingQualifierCode


        ELA


        ELD


        LLA


        LLD


        ALA


        ALD
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class PlannedJourneyLocationStatusOfHarmonization


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=0)>
        Public HandoverHarmonized As Boolean


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public HandoverHarmonizedSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>
        Public InterchangeHarmonized As Boolean


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public InterchangeHarmonizedSpecified As Boolean
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlRootAttribute("TrainActivity", [Namespace]:="", IsNullable:=False)>
    Partial Public Class TrainActivityType


        <System.Xml.Serialization.XmlElementAttribute("TrainActivityType", Order:=0)>
        Public TrainActivityType1 As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public AssociatedAttachedTrainID As CompositIdentifierPlannedType


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public AssociatedAttachedOTN As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Public Enum PlannedJourneyLocationJourneyLocationTypeCode


        <System.Xml.Serialization.XmlEnumAttribute("01")>
        Item01


        <System.Xml.Serialization.XmlEnumAttribute("02")>
        Item02


        <System.Xml.Serialization.XmlEnumAttribute("03")>
        Item03


        <System.Xml.Serialization.XmlEnumAttribute("04")>
        Item04


        <System.Xml.Serialization.XmlEnumAttribute("05")>
        Item05


        <System.Xml.Serialization.XmlEnumAttribute("06")>
        Item06


        <System.Xml.Serialization.XmlEnumAttribute("07")>
        Item07


        <System.Xml.Serialization.XmlEnumAttribute("08")>
        Item08
    End Enum


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class TrainLocationReport


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public Location As LocationIdent


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public LocationDateTime As Date


        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>
        Public TrainLocationStatus As RunningStatus


        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>
        Public BookedLocationDateTime As Date


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public BookedLocationDateTimeSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>
        Public ReferencedLocationDateTime As Date


        <System.Xml.Serialization.XmlIgnoreAttribute()>
        Public ReferencedLocationDateTimeSpecified As Boolean


        <System.Xml.Serialization.XmlElementAttribute(Order:=5)>
        Public TrainDelay As TrainDelay
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class TrainDelay


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public AgainstBooked As String


        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>
        Public AgainstReferenced As String
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class TrainOperationalIdentification


        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>
        Public TransportOperationalIdentifiers As TransportOperationalIdentifiers
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(),
     System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class TransportOperationalIdentifiers
        Inherits CompositIdentifierOperationalType
    End Class


    <System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0"),
     System.SerializableAttribute(),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Public Enum CodCauza


        SIO


        AI1


        AI2


        AI3


        AO1


        AO2


        AO3


        AO4


        AO5


        AO6


        AO7


        AB


        AF


        AN


        SI1


        SO1


        SN


        M


        B


        F


        I


        MO


        BO


        FO


        IO
    End Enum


End Namespace
