<?xml version="1.0" encoding="utf-8" ?> <xslt:stylesheet version="1.0" xmlns:xslt="http://www.w3.org/1999/XSL/Transform"                  xmlns:ext="Proceum"                  xmlns:Website="Proceum"                  exclude-result-prefixes="Website ext"                  >    <xslt:output method="html" />   <xslt:output omit-xml-declaration="yes"/>    <xslt:param name="videoId" />      <!--<xslt:template match="content">     <xslt:apply-templates select="video" >     --><!--<xslt:apply-templates select="video[@id='2']">--><!--     </xslt:apply-templates>   </xslt:template>-->   <xslt:template match="content">     <xslt:variable name="AllCount" select="count(root/videos/video[@id = $videoId])"></xslt:variable>     <xslt:choose>       <xslt:when test="$AllCount >0">         <xslt:apply-templates select="root/videos/video[@id = $videoId][1]" />       </xslt:when>       <xslt:otherwise>         <script type="text/javascript">           window.location.href = "/404error.aspx";         </script>       </xslt:otherwise>     </xslt:choose>   </xslt:template>   <xslt:template  match="video"> <xslt:variable name="nextid">              <xslt:choose>         <xslt:when test="$videoId=1">           <xslt:value-of select="2"/>         </xslt:when>         <xslt:when test="$videoId=2">           <xslt:value-of select="3"/>         </xslt:when>         <xslt:when test="$videoId=3">           <xslt:value-of select="4"/>         </xslt:when>         <xslt:when test="$videoId=4">           <xslt:value-of select="1"/>         </xslt:when>       </xslt:choose>     </xslt:variable>     <xslt:variable name="bumper" select="../brad[translate(@type, 'ABCDEFGHIJKLMNOPQRSTUVWVYZ','abcdefghijklmnopqrstuvwxyz')='bumper'][1]" />     <xslt:variable name="postroll" select="../brad[translate(@type, 'ABCDEFGHIJKLMNOPQRSTUVWVYZ','abcdefghijklmnopqrstuvwxyz')='postroll'][1]" />     <script type="text/javascript">       $(function() {         $('#HTML5video').gVideo({childtheme:'smalldark'});       });     </script>      <div id="video-holder">       <div id="start-screen">         <img src="{largeImage/@url}" width="754" height="380"></img>       </div>       <div id="end-screen">         <div id="end-middle">           <div class="left">             <h2>RELATED CONTENT</h2>             <a href="" onclick="" target="self">               <img src="http://blstb.msn.com/i/33/A8FFBCC76D1695F2832A5E7893A8F.jpg" title="Betsey Johnson rocks the runway"/>               See my bio video             </a>             <a href="" onclick="" target="self">               <img src="http://blstb.msn.com/i/DB/579111440D9A1A78A745ACF1C2B.jpg" title="Audrey Louise Reynolds: Is That Your Natural Color?"/>               Watch me work             </a>           </div>           <div class="right">             <img src="/static/i/Video/next.png" title="" />             <img src="/static/i/Video/artist_title.png" title="" />             <img src="/static/i/Video/playBtn.png" title="Play" class="play-right" onclick="window.location.href('/theme/{$nextid}');" />           </div>         </div>         <div id="end-bottom">           <a class="vid-replay" href="javascript:void(0)" onclick="Replay()">REPLAY</a>           <div class="vr"></div>           <a class="vid-share" href="javascript:void(0)" onclick="Msn.FP.Overlay.Show();">SHARE</a>         </div>       </div>       <div width="754" height="380" style="position: absolute;">         <div>       <video id="HTML5video" src="http://ht.brandent.msn.com/beet44/LEX_VD01_ShowOpen.mp4" width="754" height="380" preload="none" style="position: relative">         <p>Your user agent does not support the HTML5 Video element.</p>       </video>         </div>         <div id="vid-share-btn">           <a class="share-btn" href="javascript:void(0)" onclick="Msn.FP.Overlay.Show()"></a>         </div>       </div>            </div>     <script type="text/javascript">       var promoVideoIndex = 0;       <!--var v_bumper = <xslt:text>"</xslt:text><xslt:value-of select="$bumper/@url"/><xslt:text>";</xslt:text>-->       var v_bumper = "http://ht.brandent.msn.com/beet44/LEX_VD01_ShowOpen.mp4";       var v_main = <xslt:text>"</xslt:text><xslt:value-of select="./@mobileUrl"/><xslt:text>";</xslt:text>       var v_postroll = <xslt:text>"</xslt:text><xslt:value-of select="$postroll/@url"/><xslt:text>";</xslt:text>     </script>   </xslt:template> </xslt:stylesheet>
