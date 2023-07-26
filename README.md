<!doctype html>
<html><!-- InstanceBegin template="/Templates/Tempate.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta charset="utf-8" name='viewport' content='width=device-width, initial-scale=1'>
<!-- InstanceBeginEditable name="doctitle" -->
<title>KING_CAME</title>
<!-- InstanceEndEditable -->
<link type="text/css" rel="stylesheet" href="css/template.css">
<!-- InstanceBeginEditable name="head" --><link href="css/Trangchu.css" type="text/css" rel="stylesheet">
<script language="javascript">
  function myFunction() {
  var x = document.getElementById("myTopnav");
  if (x.className === "topnav") {
      x.className += " responsive";
  } else {
      x.className = "topnav";
  }
}

var t;
var currentIndex =1;

function next(){
      clearInterval(t);
      if (currentIndex < 3){
 	currentIndex++;
 	document.getElementById ("hinhslide").src = "imgs/images/" + currentIndex + ".jpg";
      }
      else{
 	currentIndex=1;
 	document.getElementById ("hinhslide").src = "imgs/images/" + currentIndex + ".jpg";
      }
      t = setInterval("next()", 3000);

}
function back(){
      clearInterval(t);
      if (currentIndex > 1){
 	currentIndex--;
 	document.getElementById ("hinhslide").src = "imgs/images/" + currentIndex + ".jpg"
      }
      else{
 	currentIndex=3;
 	document.getElementById ("hinhslide").src = "imgs/images/" + currentIndex + ".jpg"
      }
 
}
t = setInterval("next()", 3000);

  </script>
<!-- InstanceEndEditable -->
</head>

<body>
  <div id="container" style="max-width:1024px">
  <header>
  <div id="logo">
  	<img src="imgs/logo.png"  style="max-width:100%; max-width:100%">
  </div>
  <div id="dkdn">
  <img id="icondn" class="rightHeader" src="imgs/giohang.jpg"><a href="#">Giỏ hàng (Trống)</a><img class="rightHeader" src="imgs/images.png"><a href="dangky.html">Tài khoản của bạn</a>
  </div>
  </header>
  <div id="slider">
  <!-- InstanceBeginEditable name="slider" -->
	<div id="anh">
<img id="hinhslide" src="imgs/images/1.jpg" />
<div id="previous"><img src="imgs/images/prev.png" onClick="back()"/></div>
<div id="next"><img src="imgs/images/next.png" onClick="next()"/></div>
</div>
  <!-- InstanceEndEditable -->
  </div>
  <div class="topnav" id="myTopnav">
  	<a href="Trangchu.html"><img src="imgs/mininav.jpg"></a>
    <a href="Trangchu.html">TRANG CHỦ</a>
    <a href="gioithieu.html">GIỚI THIỆU</a>
    <a href="lienhe.html">LIÊN HỆ</a>
    <a href="sanpham.html">SẢN PHẨM</a>
    <input type=search" name="search" placeholder="Search..">
    <a href="javascript:void(0);" class="icon" onclick="myFunction()">☰</a>
  </div>
  <article>
  	<aside id="left">
    	<ul class="middle">
    	<a class="sean" href="sanpham_mayanh.html">MÁY ẢNH</a><li><a href="sanpham_mayanh.html"><img class="iconn" src="imgs/icon.png" width="58" height="39"></a></li>
        <a class="sean" href="sanpham_lens.html">LENS</a><li><a href="sanpham_lens.html"><img class="iconn" src="imgs/icon2.png" width="58" height="39"></a></li>
        <a class="sean" href="sanpham_phukienn.html">PHỤ KIỆN</a><li><a href="sanpham_phukien.html"><img class="iconn" src="imgs/icon3.png" width="58" height="39"></a></li>
    </ul>
    <div class="calender">
     <script>

<!-- Begin

  monthnames = new Array("January", "Februrary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decemeber");

  var linkcount = 0;

  function addlink(month, day, href) {

    var entry = new Array(3);

    entry[0] = month;

    entry[1] = day;

    entry[2] = href;

    this[linkcount++] = entry;

  }

  Array.prototype.addlink = addlink;

  linkdays = new Array();

  monthdays = new Array(12);

  monthdays[0] = 31;

  monthdays[1] = 28;

  monthdays[2] = 31;

  monthdays[3] = 30;

  monthdays[4] = 31;

  monthdays[5] = 30;

  monthdays[6] = 31;

  monthdays[7] = 31;

  monthdays[8] = 30;

  monthdays[9] = 31;

  monthdays[10] = 30;

  monthdays[11] = 31;

  todayDate = new Date();

  thisday = todayDate.getDay();

  thismonth = todayDate.getMonth();

  thisdate = todayDate.getDate();

  thisyear = todayDate.getYear();

  thisyear = thisyear % 100;

  thisyear = ((thisyear < 50) ? (2000 + thisyear) : (1900 + thisyear));

  if (((thisyear % 4 == 0)

  && !(thisyear % 100 == 0))

  || (thisyear % 400 == 0)) monthdays[1]++;

  startspaces = thisdate;

  while (startspaces > 7) startspaces -= 7;

  startspaces = thisday - startspaces + 1;

  if (startspaces < 0) startspaces += 7;

  document.write("<table border=2 bgcolor=white ");

  document.write("bordercolor=black><font color=black>");

  document.write("<tr><td colspan=7><center><strong>" + monthnames[thismonth] + " " + thisyear + "</strong></center></font></td></tr>");

  document.write("<tr>");

  document.write("<td align=center>Su</td>");

  document.write("<td align=center>M</td>");

  document.write("<td align=center>Tu</td>");

  document.write("<td align=center>W</td>");

  document.write("<td align=center>Th</td>");

  document.write("<td align=center>F</td>");

  document.write("<td align=center>Sa</td>");

  document.write("</tr>");

  document.write("<tr>");

  for (s = 0; s < startspaces; s++) {

    document.write("<td> </td>");

  }

  count = 1;

  while (count <= monthdays[thismonth]) {

    for (b = startspaces; b < 7; b++) {

      linktrue = false;

      document.write("<td>");

      for (c = 0; c < linkdays.length; c++) {

        if (linkdays[c] != null) {

          if ((linkdays[c][0] == thismonth + 1) && (linkdays[c][1] == count)) {

            document.write("<a href=\"" + linkdays[c][2] + "\">");

            linktrue = true;

          }

        }

      }

      if (count == thisdate) {

        document.write("<font color='FF0000'><strong>");

      }

      if (count <= monthdays[thismonth]) {

        document.write(count);

      }

      else {

        document.write(" ");

      }

      if (count == thisdate) {

        document.write("</strong></font>");

      }

      if (linktrue)

        document.write("</a>");

      document.write("</td>");

      count++;

    }

    document.write("</tr>");

    document.write("<tr>");

    startspaces = 0;

  }

  document.write("</table></p>");

  // End -->

  </script>
    </div>
    </aside>
    <section>
    <!-- InstanceBeginEditable name="section" -->
    <div id="tatcasp"> 
    <p class="phanmuc">Sản phẩm mới</p>
    	<div class="sp">
    		<img class="hinhsp" src="imgs/sp1.jpg" />
    		<p class="tensp"><a href="800D.html">CANON 800D</a></p>
    		<p class="dongia">Giá: <span class="gia">11,000,00 VND</span></p>
    </div>
    	<div class="sp">
    		<img class="hinhsp" src="imgs/sp2.jpg" />
    		<p class="tensp"><a href="M3.html">CANON M3</a></p>
    		<p class="dongia">Giá: <span class="gia">6,500,000 VND</span></p>
    </div>
   
    	<div class="sp">
    		<img class="hinhsp" src="imgs/sp3.jpg" />
    		<p class="tensp"><a href="M10.html">CANON M10</a></p>
    		<p class="dongia">Giá: <span class="gia">4,500,000 VND</span></p>
    </div>
    <div class="sp">
    		<img class="hinhsp" src="imgs/sp4.jpg" />
    		<p class="tensp"><a href="fujixt4.html">FUJIFILM XT4</a></p>
    		<p class="dongia">Giá: <span class="gia">51,000,000 VND</span></p>
    </div>
    <div class="sp">
    		<img class="hinhsp" src="imgs/sp5.jpg" />
    		<p class="tensp"><a href="SONYA6000.html">SONY A6000</a></p>
    		<p class="dongia">Giá: <span class="gia">8,500,000 VND</span></p>
    </div>
    <div class="sp">
    		<img class="hinhsp" src="imgs/sp6.jpg" />
    		<p class="tensp"><a href="M50.html">CANON M50</a></p>
    		<p class="dongia">Giá: <span class="gia">11,500,000 VND</span></p>
    </div>
    	
    </div>
  
    
  	<!-- InstanceEndEditable -->
    </section>
    <aside id="right"></aside>
  </article>
  <footer>
  	<div id="fLeft">
    	<p>KING CAME</p>
        <p>Lưu giữ nụ cười - Bắt trọn cảm xúc</p>
        <p> Địa chỉ: Bắc Tân Uyên, Bình Dương.</p>
        <p>Mail: <a href="mailto:support@kingcamerajap.com">support@kingcamerajap.com</a></p>
    </div>
    <div id="fmiddle">
   		 
  
		<table width="40" border="0" cellspacing="1">
  <tr>
    <td class="fmail">ĐĂNG KÝ NHẬN TIN</td>
  </tr>
  <tr>
    <td><input class="nhapmail" type="email" placeholder="@gmail.com " required></td>
  </tr>
  <tr>
    <td><input class="bottonmail" type="submit" value="Nhận Mail"></td>
  </tr>
</table>
</div>
    <div id="fRight">
    <ul>
		<li><a href="Trangchu.html">TRANG CHỦ</a></li>
		<li><a href="gioithieu.html">GIỚI THIỆU</a></li>
		<li><a href="lienhe.html">LIÊN HỆ</a></li>
	</ul>
<p>Copyright (c) 2011 KingCame</p>
    </div>
  </footer>
  </div>
</body>
<!-- InstanceEnd --></html>
