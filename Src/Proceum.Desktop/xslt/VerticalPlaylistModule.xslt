<?xml version="1.0" encoding="utf-8" ?> <xslt:stylesheet version="1.0" xmlns:xslt="http://www.w3.org/1999/XSL/Transform"                  xmlns:ext="Proceum"                  xmlns:Website="Proceum"                  exclude-result-prefixes="Website ext"                  >    <xslt:output method="html" omit-xml-declaration="yes" indent="yes" />       <xslt:param name="videoId" />       <xslt:template match="/root">     <div id="verticalPlaylist" style="float: left">       <ul>         <li id="1">           <a href="/theme/1">             <xslt:if test="$videoId=1">               <span class="playBtnOverlay"></span>             </xslt:if>             <img src="http://blstb.msn.com/i/82/97244268AC020F0EAA091E6211F7E.jpg" alt="Fun Finger Food" width="80" height="60" />               <h2>Jill creates easy meals you can eat with your hands.</h2>           </a>         </li>          <li id="2">           <a href="/theme/2">             <xslt:if test="$videoId=2">               <span class="playBtnOverlay"></span>             </xslt:if>             <img src="http://blstb.msn.com/i/D3/471F557EC42FF7D88E5EF48832DAC1.jpg" alt="Not Just for Kids" width="80" height="60"/>               <h2>Liz updates kid-friendly dishes with premium ingredients.</h2>           </a>         </li>          <li id="3">           <a href="/theme/3">             <xslt:if test="$videoId=3">               <span class="playBtnOverlay"></span>             </xslt:if>             <img src="http://blstb.msn.com/i/59/6D8419C97920A42A205EF0A0E2BA36.jpg" alt="Global Gourmet" width="80" height="60" />               <h2>Jackie takes us on a tour of two flavorful cultures.</h2>           </a>         </li>          <li id="4">           <a href="/theme/4">             <xslt:if test="$videoId=4">               <span class="playBtnOverlay"></span>             </xslt:if>             <img src="http://blstb.msn.com/i/C0/AFFEF60B92B4E20B9B3598C4BD880.jpg" alt="Melting Point" width="80" height="60" />               <h2>Jill faces off over easy entr�es smothered in cheese.</h2>           </a>         </li>       </ul>     </div>        </xslt:template> </xslt:stylesheet>