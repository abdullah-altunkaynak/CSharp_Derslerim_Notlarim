using System;
using static System.Math; /*Artık pow vb. metodları Math.Pow gibi kullanmamıza gerek yok. Direkt olarak Pow diyerek kullanılabilir.*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Numerics;

#region Subjects - Konular

#region Events - Olaylar
/*
    Event'ler ile ilgili bazı detaylar için notlar.
*/
#region EventArgs
/*
    Event metodlarında parametre olarak kullanılırlar. Eğer sadece 'Eventargs' parametresi varsa geri object bir değer döndürürken, bu parametrenin
yanında 'MouseEventArgs' örneğinde olduğu gibi kontrolün veya event'in ismi varsa o kontrol veya event ile ilgili özellikler geriye döner.
*/
#endregion

#region Sender
/*
    Event metodlarında object Sender tanımlaması ile görülen Sender parametresi o olayın hangi kontrol nesnesine ait olduğunu tutmaktadır. 
*/
#endregion

#endregion

#region Namespace Keywords - İsim Uzayı Anahtar Kelimeleri

#region Warning - Uyarı
/*
    Namespace içerisinde direkt scope içerisinde field, property vb. kullanılamaz. Class, struct, enum vb. yapılar kullanılmak zorundadır. Ayrıca
bu yapılar public olmak zorundadır. Eğer namespace dışarısından erişilmemesini istediğimiz işlemler varsa bunları namespace içerisindeki yapıların
içerisine yeni bir yapı oluşturup access modifiers ile sağlayabiliriz.
*/
#endregion

#region Namespace - İsim Uzayı
/*
    Namespace, isim uzayı anlamına gelmektedir. İçerisinde; Other Namespace, Class, Interface, Struct, Enum ve Delegate barındırabilmektedir.
İçerisindeki kodları organize etmek, kodları hiyerarşik bir düzende saklamamıza yardımcı olur. Benzer amaçlarla kurulan yapıları bir arada tutmamızı
sağlar. Namespace içerisindeki yapılara access modifiers sınırları dahilinde erişebilmemiz mümkündür.
*/
#endregion

#region Using Keyword - Using Anahtar Kelimesi

#region Description - Açıklama
/*
    Bir kütüphanenin/sınıfın kullanım direktifini ifade eden anahtar kelimedir. Ardına kütüphane/sınıf ismi yazılarak ; karakteri ile bildirim
yapılır.
*/
#endregion

#region Alias - Takma İsim
/*
    Using ifadesi ile kullandığımız nesnelere(Kütüphaneler/Sınıflar) takma isim vererek daha kısa olarak çağırıp kullanmamızı sağlar. Kullanımı;
Using ifadesinden sonra alias gelir ve = karakterinden sonra kullanacağımız nesne gelir. [using aliasName = Library;] Ayrıca eğer .NET kütüphaneleri
veya kendi kütüphanelerimiz herhangi bir alias almamış ise 'global' alias alırlar.
NOT: Example Of Alias region alanındaki örneği inceleyiniz.
*/
#endregion

#region Using IDisposable Interface

#region Warning - Uyarı
/*
    ASP.NET Core Version 3.X versiyonları şu anda sadece C# 8 Version desteklemektedir. ASP.NET Framework 6.X ile C# 10 Version, ASP.NET Framework 5.X
ile C# 9 Version kullanılabilmektedir. Bu özellik C# 9 ve üzeri versiyonlarda desteklenmektedir. 
*/
#endregion

#region IDisposable Interface
/*
    Bu interface, bu interface'i implement(uygulayan) eden nesnelerin kullandıkları kaynakları kullanımları tamamlandıktan sonra ram içerisinden
kaldırılması yani dispose edilmesine yarayan bir yapıdır.
*/
#endregion

#region Disposable - Tek Kullanımlık
/*
    Using ifadesi ile tanımladığımız/kullandığımız nesnelerin, Visual Studio tarafından kullanımı bittikten sonra otomatik olarak hafızadan silinmesine
yarayan bir sistemdir. Aksi halde program kapatılana kadar ram meşgul olacaktır.
*/
#endregion

#region Using IDisposable Interface
/*
    Kullanımı bittikten sonra dispose etmek istediğimiz nesneleri using ile kullanımı;
    using (ClassName ObjectName = new ClassName(Parameters))
    {
        Bu noktada bu ObjectName nesnesini kullanımını yapacağız.
    }
NOT: Example Of Using IDisposable Interface region alanındaki örneği inceleyiniz.
*/
#endregion

#endregion


#endregion

#region Extern Alias (::)
/*
    Alias verilmeyen .NET kütüphanelerine veya şahsi kütüphanelere global alias verilir demiştik. Bu global alias kullanımı şu şekilde kullanılır;
using global::alias libraryName
NOT: Example Of Extern Alias region alanındaki örneği inceleyin.
*/
#endregion

#endregion

#region Assembly
/*
    Programı oluşturan derlenmiş exe veya dll uzantılı dosyalara Assembly denir. 
*/
#endregion

#region Class Types - Sınıf Çeşitleri

#region Instance - Numune
/*
    Bir class, struct veya enum gibi yapılardan yeni bir nesne üretilmesine Instance almak denir. Örneğin Button btn = new Button(); tanımlamasında
var olan Button sınıfından ki bu sınıf form kontrolünü belirtir, yeni bir nesne üretilmesi instance örneğidir.
*/
#endregion

#region Partial Class - Parçalı Sınıf

#region Warning - Uyarı
/*
    Partial sınıflar aynı namespace içerisinde olmalıdırlar. Fakat namespace olmadan da sınıf oluşturabilir ve bunları partial yapabilmekteyiz.
Fakat bu sınıflara tüm assembly üzerinden erişilebilmektedir.
*/
#endregion

/*
    Bir sınıfı partial olarak işaretledikten sonra farklı yerlerde aynı sınıfı tekrar yazıp yeni özellikler veya metodlar tanımlayabiliriz. Örneğin
InstanceClass isimli bir sınıf oluşturalım. Bu sınıf içerisinde Form1 için bazı yöntemler yazalım. Daha sonra Form2 için yeni yöntemler yazacak
olursak farklı bir sınıf oluşturmamıza gerek yoktur. Tüm sınıf parçalarını partial olarak işaretleyerek istediğimiz alanda bu sınıfı yazabiliriz.
NOT: Example Of Partial Class region alanındaki örneği inceleyin.
*/
#endregion

#region Sealed Class - Mühürlü Sınıf
/*
    Sealed olarak ifade edilmiş sınıflar miras alınamaz sınıflardır. Sadece instance alınabilir. 
*/
#endregion

#region Static Class - Sabit Sınıf

#region Warning - Uyarı
/*
    Class içerisinde instance alınabilir yani struct, enum, class tanımlamaları static olmak zorunda değilidir.
*/
#endregion

/*
    Instance alınamayan ve direkt olarak sınıf ismi ile sınıf üyelerine erişebildiğimiz sınıf türüdür. Mantıken direkt olarak sınıf üyelerine
erişebildiğimiz için sınıf üyelerininde yani property, field, method vb. üyelerinin de static olması gerekmektedir. Buna karşın normal bir sınıf
içerisinde static üye yazılabilmektedir.
*/
#endregion

#endregion

#region Type Converting With As Keyword - As Anahtar Kelimesi ile Tip Çevirimi
/*
    Genellikle object türündeki verileri asıl tipine dönüştürmek için kullanılır. Sadece reference type için kullanılabilir.
NOT: Example Of Type Converting With As Keyword region alanında kullanımı ve örneği vardır.
*/
#endregion

#region Is Keyword - Is Anahtar Kelimesi
/*
    a is b gibi bir örnekte a, b mi anlamına gelir. Eğer a, b ise true, değil ise false döner. Example Of Is Keyword örneğinde daha iyi anlaşılır. 
*/
#endregion

#region Other Variable Types - Diğer Veri Tipleri

#region Description - Açıklama
/*
    Daha önceki derslerde de anlattığımız üzere değişkenler; Value Type ve Reference Type olmak üzere ikiye ayrılırlar. Value Type değişkenler normal
şartlarda null değer alamazken, tanımlarken sonlarına ? karakteri eklenmesi sayesinde null değer alabilmektedirler. Sonuç olarak bu değişkenlere de
nullable değişken denilir. Ayrıca Nullable olarak tanımlanan değişkenler yeni bir metoda ve iki özelliğe sahip olur.
*/
#endregion

#region Nullable Variable's Properties - Null Değer Alabilen Değişkenlerin Özellikleri
/*
    Nullable olarak tanımlanan değişklenler extra olarak iki property'e sahip olduklarını söylemiştik. Bu propertyies;
    # Value
        Nullable olarak tanımlanan değişkenin değerini dönderir. Eğer null ise hata fırlatır.
    # HasValue
        Nullable olarak tanımlanan değişkenin bir değer içerip içermediğini bildirir. Değer varsa geriye true, yoksa geriye false dönderir.
NOT: Example Of Nullable Variable's Properties region alanındaki örneği inceleyiniz.
*/
#endregion

#region Nullable Variable's Method - Null Değer Alabilen Değişkenlerin Metodu
/*
    Description alanında da söylediğimiz üzere, nullable değişkenlerin bir adet extra metodu bulunur. Bu metod;
    # returning [Nullable Variable's Type] GetValueOrDefault([Overloading Option]Type defaultValue)
        Nullable değişken içerisinde değer varsa o değeri, değer yoksa o değişken tipinin varsayılan değerini dönderir. (boolean default value is
    false, int default value is 0) Parametre değişkenin tipinde olmak zorunda bir parametre verilerek çağrılırsa içerisinde bir değer yoksa
    parametre olarak verilen değer dönderilir.
*/
#endregion

#region Why Using Nullable Variables? - Null Değer Alabilen Değişkenler Neden Kullanılır?
/*
    Nullable değişkenler genellikle database ile çalışırken kullanılmaktadır. Eğer sorgudan elde edilen sonuç null gelirse hatayı önlemek ve
tespit etmek amacı ile kullanılır.
*/
#endregion

#region Null Conditional Operator - Null Koşulu Operatörü
/*
    Eğer nullable değişkenin değeri varsa özelliklerine ulaş demek için kullanılır. C# 6 Version öncesinde bu değişkenin özelliklerine ulaştığımız
zaman eğer değişkenin değeri yoksa NullReferenceException hatası fırlatılıyordu. Bu operatör ile beraber artık hata fırlatımı yapılmadan default
değerler dönderilerek özelliklere erişilebilmektedir.
*/
#endregion

#endregion

#region Generating Unique Identity with GUID - GUID ile Benzersiz Kimlik Üretmek
/*
    Değişken için benzersiz bir kimlik numarası üretmek için kullanılan bir sınıftır. Açılımı Globally Unique Identifier olmak üzere Türkçesi
Global Benzersiz Kimlik Tanımlayıcı olarak söylenebilir. Bu sınıf rakamsal ve metinsel veri tiplerinin bir araya gelmesi ile oluşur. Hafızada
16 byte yer kullanır. Bir çok yerde kullanılabilir. Örn; internet üzerinden kaydedilecek bir resimi isimlendirirken resmin orjinal adının
yanında bir de guid ekleriz.
NOT: Kullanımını ve örneğini Example Of Generating Unique Identity With GUID region alanından görebilirsin.
*/
#endregion

#region Attributes - Öznitelikler

#endregion

#endregion

#region Homework - Ödev
/*
    1-)Environment Class için konu anlatımı hazırlayın.
    2-)StringBuilder Class için konu anlatımı hazırlayın.
    3-)XML oluşturma, yazma, okuma için konu anlatımı hazırlayın. Merkez Bankasından Döviz Kurlarını 1 sn de bir çeken örnek program yazın.
    4-)JSON oluşturma, yazma, okuma için konu anlatımı hazırlayın.
    5-)BigInteger yapısı için konu anlatımı hazırlayın.
*/
#endregion

namespace Extra
{
        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Example Of Is Keyword Apply
            /*
            int variable = 5;
            NewNamespace.MainClass.WhatTypeIsThis(variable);
            */
            #endregion

            #region Example Of Nullable Variable's Properties Apply
            /*NewNamespace.MainClass.NullableVariableProperty(null);*/
            #endregion

            #region Example Of Nullable Variable's Method Apply
            /*NewNamespace.MainClass.NullableVariableMethod(null);*/
            #endregion

            #region Example Of Generating Unique Identity With GUID Apply
            /*NewNamespace.MainClass.GenerateUniqueId();*/
            #endregion

            #region Example Of Assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            assembly.GetTypes().ToList().ForEach(
                item =>
                {
                    listBox1.Items.Add(string.Format($"Name: {item.Name}"));
                    item.GetProperties().ToList().ForEach(
                        pItem =>
                        {
                            listBox2.Items.Add(string.Format($"Property Name: {item.Name}.{pItem.Name}"));
                        });
                    item.GetMethods().ToList().ForEach(
                        mItem =>
                        {
                            listBox3.Items.Add(string.Format($"Method Name: {item.Name}.{mItem.Name}"));
                        });
                });
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1920, 1080);
            this.WindowState = FormWindowState.Maximized;
            listBox1.Size = new Size((this.Width / 3) - 50, 1000);
            listBox2.Size = new Size((this.Width / 3) - 50, 1000);
            listBox2.Location = new Point((this.Width / 3), 20);
            listBox3.Size = new Size((this.Width / 3) - 50, 1000);
            listBox3.Location = new Point((this.Width / 3) * 2, 20);
            label1.Location = new Point(listBox1.Location.X + (listBox1.Size.Width / 2) - (label1.Size.Width / 2), 0);
            label2.Location = new Point(listBox2.Location.X + (listBox2.Size.Width / 2) - (label2.Size.Width / 2), 0);
            label3.Location = new Point(listBox3.Location.X + (listBox3.Size.Width / 2) - (label3.Size.Width / 2), 0);
            #region Example of Environment Class for Homework-1
            /*ArrayList arr = new ArrayList();
            arr.Add("OSVersion: " + Environment.OSVersion.ToString());   
            arr.Add("OSVersion Platform: " + Environment.OSVersion.Platform.ToString());   
            arr.Add("OS Version: " + Environment.OSVersion.Version.ToString());   
            arr.Add("MachineName :" + Environment.MachineName.ToString());  
            arr.Add("Is64BitProcess : " + Environment.Is64BitProcess.ToString());  
            arr.Add("UserDomainName: " + Environment.UserDomainName.ToString());
            arr.Add("UserName :  " + Environment.UserName.ToString()); 
            arr.Add("WorkingSet :" + Environment.WorkingSet.ToString());   
            arr.Add("CurrentDirectory: " + Environment.CurrentDirectory.ToString());  
            arr.Add("HasShutdownStarted:" + Environment.HasShutdownStarted.ToString());  
            arr.Add("SystemPageSize:" + Environment.SystemPageSize.ToString());
            foreach (var item in arr)
                MessageBox.Show(item.ToString());*/
            #endregion

            #region Example of StringBuilder Class for Homework-2
            /*// 50 karakter tutacağını ve ABC ile başlayacağını söylediğimiz bir nesne oluşturalım.
            StringBuilder sb = new StringBuilder("ABC", 50);
            // StringBuilder'ın sonuna DEF karakterlerini ekleyelim
            sb.Append(new char[] { 'D', 'E', 'F' });
            // StringBuilder'ın sonuna bir biçim dizesi ekleyelim.
            sb.AppendFormat("GHI{0}{1}", 'J', 'k');
            // Kaç karakterden oluştuğunu gösterelim ve stringi yazdıralım.
            MessageBox.Show("Uzunluğu: " + sb.Length.ToString() + " Metin: " + sb.ToString());
            // Stringin başına bir dize ekleyelim.
            sb.Insert(0, "Alphabet: ");
            // Küçük k leri büyük K ye çevirelim
            sb.Replace('k', 'K');
            // Kaç karakterden oluştuğunu gösterelim ve stringi yazdıralım.
            MessageBox.Show("Uzunluğu: " + sb.Length.ToString() + " Metin: " + sb.ToString());
            listBox1.Items.Clear();
            label1.Text = "Show StringBuilder Info";
            ShowSBInfo(sb);
            sb.Append("Cümle");
            ShowSBInfo(sb);
            for (int ctr = 0; ctr <= 10; ctr++)
            {
                sb.Append("Ek cümle");
                ShowSBInfo(sb);
            }*/
            #endregion

            #region Receive daily exchange rates of the TCMB with XML
            /*XmlDocument xmlVerisi = new XmlDocument();
            xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            //Xpath kısmında yazmamız gereken etiketleri öğrenebilmemiz için siteye giriyoruz sayfa kaynağını görüntüle diyoruz ve etiketleri inceleyip,
            //string.format()kısmında etikete göre işlem yapıyoruz.
            //TCMB sitesinde kurlar nokta ile ayırılı onları virgül ile almalıyız yoksa noktayı görmüyor.
            double dolar = Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
            double euro = Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
            double sterlin = Convert.ToDouble(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
            listBox1.Items.Clear();
            label1.Text = "Dövizler";
            listBox1.Items.Add("dolar: " + dolar.ToString());
            listBox1.Items.Add("euro: " + euro.ToString());
            listBox1.Items.Add("sterlin: " + sterlin.ToString());*/
            #endregion

            #region JSON Currency Example
            /*listBox1.Items.Clear();
            label1.Text = "Döviz Kurları";
            string address = "http://www.floatrates.com/daily/try.json";
            WebRequest request = HttpWebRequest.Create(address);
            WebResponse response;
            response = request.GetResponse();
            StreamReader responseData = new StreamReader(response.GetResponseStream());
            string data = responseData.ReadToEnd();
            Root rootData = JsonConvert.DeserializeObject<Root>(data);
            listBox1.Items.Add("1 " + rootData.usd.name + " = " + rootData.usd.inverseRate.ToString() + " TL");
            listBox1.Items.Add("1 " + rootData.eur.name + " = " + rootData.eur.inverseRate.ToString() + " TL");
            listBox1.Items.Add("1 " + rootData.gbp.name + " = " + rootData.gbp.inverseRate.ToString() + " TL");*/
            #endregion

            /*MessageBox.Show(Factorial(100).ToString());
            MessageBox.Show(FactorialOld(100).ToString());*/
        }
        #region Show StringBuilder info method
        private void ShowSBInfo(StringBuilder sb)
        {
            foreach (var prop in sb.GetType().GetProperties())
            {
                if (prop.GetIndexParameters().Length == 0)
                    listBox1.Items.Add(prop.Name + prop.GetValue(sb));
            }
        }
        #endregion

        #region Long and BigInteger factorial comparison 
        static BigInteger Factorial(int value)
        {
            if (value == 1)
                return 1;
            else
                return value * Factorial(value - 1);
        }
        static long FactorialOld(int value)
        {
            if (value == 1)
                return 1;
            else
                return value * FactorialOld(value - 1);
        }
        #endregion
    }
}
#region JSON Classes
public class Usd
{
    public string code { get; set; }
    public string alphaCode { get; set; }
    public string numericCode { get; set; }
    public string name { get; set; }
    public double rate { get; set; }
    public string date { get; set; }
    public double inverseRate { get; set; }
}
public class Eur
{
    public string code { get; set; }
    public string alphaCode { get; set; }
    public string numericCode { get; set; }
    public string name { get; set; }
    public double rate { get; set; }
    public string date { get; set; }
    public double inverseRate { get; set; }
}
public class Gbp
{
    public string code { get; set; }
    public string alphaCode { get; set; }
    public string numericCode { get; set; }
    public string name { get; set; }
    public double rate { get; set; }
    public string date { get; set; }
    public double inverseRate { get; set; }
}
public class Root
{
    public Usd usd { get; set; }
    public Eur eur { get; set; }
    public Gbp gbp { get; set; }
}
#endregion

#region Example Of Using IDisposable Interface
/*
using (Font myFont = new Font("Arial", 10.0f)
{

}
*/
#endregion

#region Example Of Alias
//using S = System; /*Artık System Library yerine S kullanarak kütüphane içerisideki nesnelere ulaşabiliriz. Örn; S.Console.WriteLine();*/
#endregion

#region Example Of Extern Alias
/*Tabiki burada VB kontrolleri kullanılamaz çünkü reference eklemesi yapmadık. Solition Explorer içerisinden Dependenicies yani bağımlılıklar kısmına
sağ tıklayarak Add Project Refernces veya Project menüsünden Add Project Refernces seçilerek VB dahil edilir ise kullanım mümkündür.*/
//using global::Microsoft.VisualBasic;
#endregion

#region Example Of Partial Class
/*Herhangi bir namespace olmadan da tanımlanabilirdi. Eğer o şekilde tanımlansaydı sınıfa tüm assembly üzerinden erişilebilirdi.*/
namespace NewNamespace
{
    public partial class InstanceClass
    {
        public int Prop { get; set; }
        public void Meth()
        {
            MessageBox.Show("First Meth Method!");
        }
    }
}

namespace NewNamespace
{
    public partial class InstanceClass
    {

    }
}
#endregion

#region Example Of Type Converting With As Keyword
namespace NewNamespace
{
    public partial class MainClass
    {
        public object testVariable;
        public void TestMethod()
        {
            InstanceClass instance = testVariable as InstanceClass;
            /*Görüldüğü üzere kendi sınıflarımız için de kullanılabilir. Buradaki InstanceClass sınıfı Partial örneğinden gelmektedir.*/
        }
    }
}
#endregion

#region Example Of Is Keyword
/*Object ile gönderilen bir parametrenin değişken tipini öğrenelim.*/
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void WhatTypeIsThis(object variable)
        {
            if (variable is null)
                return; /*Void olduğu için hiçbir şey döndürmüyor sadece metodu sonlandırmak için return kullanıyoruz.*/
            else if (variable is int)
                MessageBox.Show("This Variable's Type Is Integer!", "Succesfully");
            else if (variable is double)
                MessageBox.Show("This Variable's Type Is Double!", "Succesfully");
            else if (variable is string)
                MessageBox.Show("This Variable's Type Is String!", "Succesfully");
        }
    }
}
#endregion

#region Example Of Nullable Variable's Properties
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void NullableVariableProperty(int? nullableParameter)
        {
            MessageBox.Show($"Nullable Parameter's HasValue Property Value = {nullableParameter.HasValue}", "nullableParameter.HasValue");
            /* Hata fırlatacaktır. Çünkü metod çağrılırken null değeri verildi.
            MessageBox.Show($"Nullable Parameter's Value Property Value = {nullableParameter.Value}", "nullableParameter.Value");*/
            int? nullableVariable = 5;
            MessageBox.Show($"Nullable Variable's HasValue Property Value = {nullableVariable.HasValue}", "nullableParameter.HasValue");
            MessageBox.Show($"Nullable Variable's Value Property Value = {nullableVariable.Value}", "nullableParameter.Value");
            nullableVariable = null;
            MessageBox.Show($"Nullable Variable's HasValue Property Value = {nullableVariable.HasValue}", "nullableParameter.HasValue");
            string? nullableText = null;
            /*Aşağıdaki MessageBox.Show metodu için Bkz. (Null Conditional Operator)*/
            MessageBox.Show($"Nullable Variable's Lenght = {nullableText?.Length}", "Nullable Variable's Properties!");
            /* Hata fırlatacaktır. Çünkü nullableVariable değeri yoktur(null).
            MessageBox.Show($"Nullable Variable's Value Property Value = {nullableVariable.Value}", "nullableParameter.Value");*/
        }
    }
}
#endregion

#region Example Of Nullable Variable's Method
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void NullableVariableMethod(int? nullableParameter)
        {
            MessageBox.Show($"GetValueOrDefault Method's Result = {nullableParameter.GetValueOrDefault(-1)}", "Succesfully!");
        }
    }
}
#endregion

#region Example Of Generating Unique Identity With GUID
namespace NewNamespace
{
    public partial class MainClass
    {
        public static void GenerateUniqueId()
        {
            string id = Guid.NewGuid().ToString();
            MessageBox.Show(id, "Unique Identity");
            /*Sonuç - karakterleri ile birlikte üretilir. Bunu string parametre vererek format bildirerek düzenleyebiliriz. */
        }
    }
}
#endregion

#region Homework-1 -> What is Environment class ?
/*  Environment class, sistem yapılandırmasını sağlayan static bir sınıftır. Geçerli program yürütme ortamı ve haber satırı gibi dize işleme
    için bazı özellikleri, sistem ad alanını ve ortam sınıfını temsil eder.
    Environment class, anahtar, değer çiftleri biçiminde kimlik kullanarak ortam değişken ayrıntılarını temsil eden işlevlerin ve özelliklerin
    bir bileşimidir.
    Environment class static olduğu için yeni bir nesne oluşturmadan doğrudan sınıf adının yardımıyla yöntemlere ve özelliklere erişiriz.
    Bazı özellikler ve metodları inceleyelim;
    Environment.OSVersion: İşletim sistemi ayrıntıları. 
    Environment.NewLine: Bu ortam için tanımlanan yeni satır dizesini alır.
    Environment.MachineName: Makine adı.
    Environment.Is64BitProcess: Sistemin 64 bit olup olmadığını kontrol eder.
    Environment.ProcessorCount: Geçerli makinede çalışmakta olan işlem sayısını alır.
    Environment.UserDomainName: Geçerli Kullanıcı Bilgisayarı ile ilişkilendirilmiş olan ağ etki alanı adını alır. 
    Environment.UserName: Windows işletim sisteminde oturum açmış olan kişinin kullanıcı adını alır.
    Environment.WorkingSet: İşlem bağlamıyla eşlenen fiziksel bellek miktarını alır.
    Environment.Exit(int): işlemi sonlandırır ve temel alınan işletim sistemine Belirtilen çıkış kodunu verir.
    Environment.CurrentDirectory: Geçerli çalışma dizininin tam yolunu alır.
    Environment.HasShutdownStarted: CLR'nin kapanıp kapanmadığının değerini alır.
    Environment.SystemPageSize: Bir işletim sisteminin Sayfa dosyası için bellek miktarını alır.
    Daha fazla property ve method bulunmaktadır !
    Exapmle of Environment Class for Homework-1 region alanından örnekleri inceleyebilirsiniz.
 */

#endregion

#region Homework-2 -> What is Stringbuilder class ?
/*  StringBuilder String Her ikisi de karakter dizilerini temsil etse de farklı şekilde uygulanır. String sabit bir türdür.
    Diğer bir deyişle, bir nesneyi değiştirmek için görünen her işlem, String aslında yeni bir dize oluşturur. Bu davranış, orijinal dize
    değiştirilerek, eklenerek, kaldırılarak veya orijinal dizeye yeni dizeler eklenerek birden çok kez değiştirilirse performansı engeller.
    Bu sorunu çözmek için C#'da Stringbuilder kullanılır ve bu sınıfı kullanmak için System.text ad alanını projeye dahil etmek gerekir.
    Stringbuilder bellekte yeni bir nesne oluşturmaz ama değiştirilen dizeye uyum sağlamak için belleği dinamik olarak genişletir.
    new anahtar sözcüğünü kullanarak ve bir başlangıç dizesi ileterek StringBuilder sınıfının bir nesnesini oluşturabilirsiniz. Aşağıdaki örnek,
    StringBuilder nesnelerinin oluşturulmasını gösterir.
    StringBuilder sb = new StringBuilder("Hello World!");
    İsteğe bağlı olarak, aşağıda gösterildiği gibi overloaded oluşturucuları kullanarak StringBuilder nesnesinin maksimum kapasitesini de
    belirtebilirsiniz.
    StringBuilder sb = new StringBuilder("Hello World!", 50);
    Yukarıda, C#, bellek yığınında sırayla en fazla 50 boşluk ayırır. Belirtilen kapasiteye ulaştığında bu kapasite otomatik olarak iki katına
    çıkacaktır. StringBuilder nesnesinin kapasitesini ayarlamak veya almak için kapasite veya uzunluk özelliğini de kullanabilirsiniz.
    Stringbuilder Class'ın property ve methodları şu şekildedir;
    Capacity: Geçerli örnek tarafından ayrılan belleğe dahil olabilecek en fazla karakter sayısını alır veya ayarlar.
    Chars[Int32]: Bu örnekteki belirtilen karakter konumundaki karakteri alır veya ayarlar. // dizi index ulaşmasıdır kısaca.
    Length: Geçerli nesnenin uzunluğunu alır.
    MaxCapasity: Bu örneğin maksimum kapasitesini alır.
    Append(Boolean): Belirtilen Boolean değerin dize gösterimini bu örneğe ekler. // (byte),(char),(char, int32),(decimal),(double) gibi kullanımları vardır.
    Clear(): Geçerli örnekten tüm karakterleri kaldırır.
    CopyTo(Int32, Char[], Int32, Int32): Bu örneğin belirtilen segmentinden gelen karakterleri, hedef dizinin belirtilen segmentine kopyalar.
    Equals(Object): Belirtilen nesnenin geçerli nesneye eşit olup olmadığını belirler.
    GetType(): Type Geçerli örneği alır.
    Insert(): Ekleme yapmak için.
    MemberwiseClone(): Geçerli bir basit kopyasını oluşturur.
    Remove(Int32, Int32): Bu örnekten belirtilen karakter aralığını kaldırır.
    Replace(Char, Char): Bu örnekteki belirtilen bir karakterin tüm oluşumlarını, belirtilen başka bir karakterle değiştirir.
    ToString(): Değeri string olarak değiştirir.
    Yazmadığımız property ve methodlar vardır. En çok kullanılanlar bu şekildedir.
    Stringbuild'in özellikleri özet olarak.
    1-StringBuilder değişkendir.
    2-StringBuilder, birden çok dize değeri eklerken dizeden daha hızlı çalışır.
    3-Üç veya dörtten fazla dize eklemeniz gerektiğinde StringBuilder'ı kullanın.
    4-StringBuilder nesnesine dize eklemek için Append() yöntemini kullanın.
    5-StringBuilder nesnesinden bir dize almak için ToString() yöntemini kullanın.
    Example of StringBuilder Class for Homework-2 region alanından örnekleri inceleyebilirsiniz.
 */
#endregion

#region Homework-3 -> Create, writing and reading to XML
/*
    Visual Studio ile proje oluşturulurken Visual Stuido tarafından oluşturulan MSBuild ayarları, uygulama ayarları XML dosyalarında saklanır.
    Ayrıca ADO.NET ile veritabanı işlemlerinde, platformlar arası veri alışverişinde JSON ile birlikte giderek azalsa da XML kullanılır.
    .NET içerisinde XML işlemleri sıklıkla kullanıldığından dolayı System.Xml alanında XML okuma, yazma, doğrulama gibi işlemler için sınıf ve
    arayüzler yer alır.
    XmlWriter ve XmlReader: .NET System.Xml alanında yer alan soyu XmlWriter ve XmlReader sınıfları adlarından da anlaşışacağı üzere XML okuma ve yazma
    işlemleri için kullanılır. Sınıflar soyut olduklarından dolayı Create metodu ile oluşturulurlar. Metot parametre olarak dosya yolu, akım ve XML
    ayarlarını (XmlWriterSettings) parametre alan aşırı yüklenmiş kullanıma sahiptir. XmlReader ile XML okuma işlemi XmlWriter sınıfına göre daha zordur
    çünkü okuma işlemi tek yönlü yapılır ve okuma işleminin kontrol edilmesi gerekir.
    XmlDocument: XML okuma ve yazma işlemlerini daha kolay bir şekilde yapmak için XmlDocument sınıfı ve yardımcı sınıfları kullanılabilir. XmlDocument
    sınıfının XmlWriter ve XmlReader sınıflarından farkı XmlDocument XML dosyasını belleğe bilgisayar bilimlerinde yer alan ağaç veri yapısı biçiminde
    yerleştirerek veri erişimine imkan vermesidir.
    XML serialization: C# ile XML işlemlerini kolay bir şekilde yapmanın diğer bir yolu ise XML serileştirme yöntemini kullanmaktır. Sınıfa
    serileştirme özelliği kattıktan sonra System.Xml.Serialization alanında yer alan XmlSerializer sınıfı ile veriler XML formatında kaydedilebilir.
    --> örnek:
    [Serializable]
    class Sinif 
    {
    public string ADI { get; set; }
    public string SOYADI { get; set; }
    }
    string xmlDosyasi = @"dosya.xml";
    Sinif s1 = new Sinif
    {
        ADI = "Abdullah",
        SOYADI = "ALTUNKAYNAK"
    };

    FileStream fileStream = new FileStream(xmlDosyasi, FileMode.Open);
    XmlSerializer xmlSerializer = new XmlSerializer(s1.GetType());
    xmlSerializer.Serialize(fileStream, s1);
    fileStream.Close(); <--
    Serileştirme işlemi diğer işlemlere göre daha kolay olsa da yeni bir sınıf oluşturmak ve verilerin büyük küçük harf değişikliğine göre uyuşmaması
    beklenmedik sonuçlar çıkarabilir.
    Bazı property ve metodlar;
    SelectSingleNode(): Xpath sorgusu sonucunda tek bir elemana ulaşmak için SelectSingleNode metodu kullanılır.
    SelectNodes(): Xpath sorgusu sonucunda birden çok elemana ulaşmak için SelectNodes metodu kullanılır.
    Load(): Okuma işlemi için load metodu kullanılır.
    InnerText: Düğümün birleştirilmiş değerlerini ve tüm alt düğümlerini alır veya ayarlar.
    Receive daily exchange rates of the TCMB with XML örneğini inceleyebilirsiniz.
    
 */
#endregion

#region Homework-4 -> What is JSON and how to create, write and read ?
/*
    JSON (Javascript Object Notation) türkçesiyle Javascript Nesne Gösterimi. JSON bir ağaç yapısıyla çalışır ve XML mantığına benzerdir.
    Ağaç yapısından ve kendisinin sunduğu özellikten dolayı, XML’den daha kolay ve daha hızlı işleyebilmekteyiz. Bağımsızdır, kısadır ve anlaşılabilir
    bir yapıdadır. Eğer ikincil bir kaynaktan veri alışverişinde bulunulmak isteniyorsa JSON kullanılabilir. XML gibi keyler ve valuelerden oluşur.
    Örneğin -> "sehir":"konya", "ısım":"Abdullah" gibi.
    Solution Explorer üzerinden References kısmına sağ tıklayarak, JSON için ilgili kütüphaneyi kurmamız gerekir(Newtonsoft.Jon).
    JSON formatında yazılı koda Serialize, c# formatına çevirilmiş JSON koduna ise Deserialize kod denir. Yani elimizde c# formatında bir veri var ve
    biz bu veriyi JSON formatında yazdırmak istiyorsak Serialize işlemi yapmalıyız ve tam tersi olarak JSON formatında bir verimiz varsa ve biz bu veriyi
    c# formatında yazdırmak veya okuma istiyorsak Deserialize işlemi yapmalıyız. Bu işlemleri yapabiliyor olduktan sonra istersek Web bağlantımızı oluşturarak
    JSON verisini çekebiliriz ya da c# verisini JSON formatında yazdırabiliriz.
    
 */
#endregion

#region Homework-5 -> What is BigInteger ?
/*
    BigInteger adından da anlaşılacağı üzere çok büyük verileri tutmamız için kullanacağımız bir değer türüdür. Bu değer türü .NET 4.0 ile birlikte gelen
    yeniliktir. BigInteger System.Numerics namespace'ine dahildir. Diğer veri türlerinden öte belirli bir sınırının veya aralığının olmayışı bize ihtiyaç
    halinde yardım edecektir. BigInteger tipi sahip olduğu static metodlar sayesinde çok yüksek haneli sayılar ile kolayca çalışılabilmesine olanak
    sağlamaktadır. Bu sayı çift mi, bu sayı bu sayıdan büyük mü ya da küçük mü, bu sayı 2nin üssü mü, negatif mi yoksa pozitif mi gibi soruların cevaplarını
    metodları sayesinde kolayca öğrenebiliriz. Peki bir uygulama yazıyoruz, BigInteger kullanıyoruz bunun bir sınırı yok mu ? Tabiki de var. Burada devreye
    Visual Studio giriyor ve karşımıza OutOfMemoryException diye birşey çıkarıyor. Eğer uygulamamız 32 bitlik sistemlerde en fazla 2GB sanal kullanıcı
    modu belleği ve 64 bitlik sistemlerde en fazla 4GB sanal kullanıcı modu belleği ayırır. Bu gerekli zamanlarda değiştirilebilir ve 64 bitlik sistem için
    8 TB kadar çıkartılabilir. Sınır aşımı olması durumunda şu hatayla karşılaşırız -> Out of Memory: Insufficient memory to continue the execution of
    the program.
 */
#endregion