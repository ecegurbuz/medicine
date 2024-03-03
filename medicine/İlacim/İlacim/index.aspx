<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="İlacim.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <header>
                <div class="logo" >
                    <ul>
                        <li>
                    <a href="index.aspx">
                    ilacım
                        </a>
                            </li>
                        </ul>

                </div>

                
               
                <div class="arama-wrap">

                    <asp:TextBox ID="txtArama" CssClass="txtArama" runat="server"  placeholder="ilaç adı, kategori(tansiyon vb.)"/>
                    <asp:Button ID="butonArama" CssClass="butonArama" Text="Ara" runat="server" OnClick="butonArama_Click"/>
                    
                </div>

                <nav id="alt-nav">

                    <ul>
                        
                    <li><a href="a.aspx">A</a></li>
                    <li><a href="b.aspx">B</a></li>
                    <li><a>C</a></li>
                    <li><a>D</a></li>
                    <li><a>E</a></li>
                    <li><a>F</a></li>
                    <li><a>G</a></li>
                    <li><a>H</a></li>
                    <li><a>I</a></li>
                    <li><a>J</a></li>
                    <li><a>K</a></li>
                    <li><a>L</a></li>
                    <li><a>M</a></li>
                    <li><a>N</a></li>
                    <li><a>O</a></li>
                    <li><a>P</a></li>
                    <li><a>Q</a></li>
                    <li><a>R</a></li>
                    <li><a>S</a></li>
                    <li><a>T</a></li>
                    <li><a>U</a></li>
                    <li><a>V</a></li>
                    <li><a>W</a></li>
                    <li><a>X</a></li>
                    <li><a>Y</a></li>
                    <li><a>Z</a></li>
                          

               
                    </ul>


                </nav>
            </header>
            
           
               
                <div id="banner">
               <div class="sol">
                   <a href="https://saglik.gov.tr/">
                       <img src="NewFolder1/virüs.jpeg" width="250" height="450"/>
                     </a>

               </div>
                   

                     
               <div class="icerik">

                   
                   <ol>
  
                       <li>Bilgilerini bulmak istediğiniz ilacın başharfini yukarıdaki 
                       kısımdan girerek ilaca kısa sürede ulaşabilirsiniz.
                       (Örneğin Aferin için yukarıdan A harfine girerek A harfi ile
                       başlayan ilaçların olduğu listeye ulaşabilirsiniz.)</li>
  
                       <li>Yukarıdaki arama kısımdan ilacın ismini yazarak ulaşabilirsiniz. 
                       (Arveles ilacına ulaşmak istiyorsanız arama kısmına Arveles yazmanız yeterli olacaktır)</li>
  
                       <li>Hangi hastalık ilacı olduğunu(tansiyon,kalp...) yazarak ilaca ulaşabilirsiniz.
                       (Tansiyon ilaçlarını arıyorsanız arama kısmına tansiyon yazmanız yeterlidir.)</li>

                       <li>Aradığınız ilacı bulduktan sonra üstüne tıklayarak yan etkiler nasıl kullanılır gibi kısımlara ulaşabilirsiniz.</li>


                   </ol>


               </div>
                   
                   <div class="sag">
                       <a href="https://saglik.gov.tr/">
                       <img src="NewFolder1/sağlık.png" width="250" height="450"/>
                     </a>
                 </div>
                    </div>

               
               

           <footer class="footer"></footer>

        </div>
       
       
    </form>
</body>
</html>
