<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website.MVC.Layouts.Default" %>

<!DOCTYPE html>
<!-- paulirish.com/2008/conditional-stylesheets-vs-css-hacks-answer-neither/ -->
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js" lang="en">
<!--<![endif]-->
<head runat="server">
    <title><%= BasePageModel.BrowserTitle %> - Sitecore User Group Nederland (SUGNL)</title>
    <meta charset="utf-8" />
    <!-- Set the viewport width to device width for mobile -->
    <meta name="viewport" content="width=device-width" />

    <!-- Included CSS Files (Uncompressed) -->
    <!--<link rel="stylesheet" href="stylesheets/foundation.css">-->

    <!-- Included CSS Files (Compressed) -->
    <link rel="stylesheet" href="~/stylesheets/foundation.css">
    <link rel="stylesheet" href="~/stylesheets/app.css">
    <link rel="stylesheet" href="~/stylesheets/jquery.fancybox.css" />
    <link rel="shortcut icon" href="~/favicon.ico" type="image/x-icon" />
    <script src="~/javascripts/modernizr.foundation.js"> </script>

    <!-- IE Fix for HTML5 Tags -->
    <!--[if lt IE 9]>
        <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"> </script>
    <![endif]-->
</head>
<body id="body" runat="server">
    <form id="form1" runat="server">
        <!-- 
            Door: Maarten Hunink, Zinnebeeld
            Versie: 1.0
            Licentie: Creative Commons Naamsvermelding 3.0
            Gebruik: Plaats code net onder de <body> tag.
            -->
        <!--[if lte IE 7]>
            <style type="text/css">
                #ie7_banner {
                    background: #333;
                    border-bottom: 1px solid #111;
                    margin: 0;
                    padding: 15px 0;
                    position: relative;
                    width: 100%;
                    z-index: 999;
                }

                #ie7_wrap {
                    margin: 0 auto;
                    width: 1000px;
                }

                #ie7_wrap h1 {
                    background: none;
                    color: #fff;
                    font-size: 18px;
                    font-weight: bold;
                    margin: 0 0 10px;
                    padding: 0;
                    text-transform: none;
                }

                #ie7_wrap p {
                    background: none;
                    color: #fff;
                    font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif;
                    font-size: 12px;
                    font-weight: normal;
                    line-height: 16px;
                    margin: 0;
                    text-align: left;
                }

                #ie7_wrap p a {
                    background: none;
                    color: #fff;
                    font-size: 12px;
                    text-decoration: underline;
                }

                #ie7_wrap p a:hover {
                    background: none;
                    color: #fff;
                    text-decoration: none;
                }

                #ie7_links {
                    float: right;
                    width: 272px;
                }

                #ie7_links a {
                    background: #5a5a5a;
                    color: #fff;
                    float: left;
                    height: 27px;
                    margin: 0 1px 1px 0;
                    padding: 12px 0 0 50px;
                    width: 85px;
                }

                #ie7_links a:hover { text-decoration: underline; }

                #ie7_links img {
                    border: none;
                    margin: -5px 0 0 -35px;
                    position: absolute;
                }
            </style><div id="ie7_banner"><div id="ie7_wrap"><div id="ie7_links"><a href="http://www.mozilla.com/nl"><img src="http://www.wijstoppenook.nl/site/gfx/firefox_small.png" alt="" />Firefox</a><a href="http://www.google.com/chrome"><img src="http://www.wijstoppenook.nl/site/gfx/chrome_small.png" alt="" />Chrome</a><a href="http://www.apple.com/safari"><img src="http://www.wijstoppenook.nl/site/gfx/safari_small.png" alt="" />Safari</a><a href="http://www.opera.com"><img src="http://www.wijstoppenook.nl/site/gfx/opera_small.png" alt="" />Opera</a> </div><h1>U gebruikt een verouderde versie van Internet Explorer</h1><p>Helaas wordt Internet Explorer 7 of lager niet meer ondersteund op deze website. Wij raden u aan over te schakelen naar een moderne internetbrowser. U kunt natuurlijk kiezen voor <a href="http://www.microsoft.com/ie">Internet Explorer 9</a>. Beter nog kiest u een browser uit het overzicht hiernaast.<br /> Deze browsers zijn veelal sneller, veiliger en voldoen beter aan de webstandaarden.</p></div></div>
        <![endif]-->
        <div class="topContainer">
            <div class="top-header">
                <sc:Placeholder runat="server" Key="header" />
            </div>
            <div class="top-bottom">
                <sc:Placeholder runat="server" Key="top-bottom" />
            </div>
        </div>
        <sc:Placeholder runat="server" Key="content" />

        <div class="footer">
            <sc:Placeholder runat="server" Key="footer" />
        </div>
        <div class="disclaimer">
            <div class="row">
                <div class="twelve columns">
                    <sc:Placeholder runat="server" Key="disclaimer" />
                </div>
            </div>
        </div>

        <!-- Included JS Files (Uncompressed) -->
        <!--
  
            <script src="javascripts/modernizr.foundation.js"></script>
  
            <script src="javascripts/jquery.js"></script>
  
            <script src="javascripts/jquery.foundation.mediaQueryToggle.js"></script>
  
            <script src="javascripts/jquery.foundation.reveal.js"></script>
  
            <script src="javascripts/jquery.foundation.orbit.js"></script>
  
            <script src="javascripts/jquery.foundation.navigation.js"></script>
  
            <script src="javascripts/jquery.foundation.buttons.js"></script>
  
            <script src="javascripts/jquery.foundation.tabs.js"></script>
  
            <script src="javascripts/jquery.foundation.forms.js"></script>
  
            <script src="javascripts/jquery.foundation.tooltips.js"></script>
  
            <script src="javascripts/jquery.foundation.accordion.js"></script>
  
            <script src="javascripts/jquery.placeholder.js"></script>
  
            <script src="javascripts/jquery.foundation.alerts.js"></script>
  
            -->

        <!-- Included JS Files (Compressed) -->
        <script src="/javascripts/foundation.min.js"> </script>
        <script src="/javascripts/jquery.mousewheel-3.0.6.pack.js"></script>
        <script src="/javascripts/jquery.fancybox.js"></script>
        <!-- Initialize JS Plugins -->
        <script src="/javascripts/app.js"> </script>
        <script type="text/javascript">
            $(document).ready(function () {
                $(".fancybox").fancybox();
            });
        </script>
    </form>
</body>
</html>
