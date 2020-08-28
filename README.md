# VP_Tanca-Exemplo_CSHARP

<p><a name="_Toc47360310"></a></p>
<h1 style="text-align: center;"><strong>MANUAL DE DESENVOLVIMENTO</strong></h1>
<h1 style="text-align: center;"><strong>LINHA VP TANCA&nbsp;</strong></h1>
<p>&nbsp;</p>
<p style="text-align: center;">&nbsp;</p>
<p style="text-align: center;">Vers&atilde;o da DLL: 3.0.0.4</p>
<p style="text-align: center;">Agosto de 2020</p>
<p>&nbsp;</p>
<p style="text-align: justify;">O presente material de apoio &eacute; de cunho t&eacute;cnico-informativo, para que equipes de&nbsp; desenvolvedores recebam instru&ccedil;&otilde;es quanto ao funcionamento de nossa DLL, necess&aacute;ria para o desenvolvimento de solu&ccedil;&otilde;es que far&atilde;o uso dos Verificadores de Pre&ccedil;o produzidos pela Tanca.</p>
<p style="text-align: justify;">Todos os direitos quanto ao conte&uacute;do deste documento est&atilde;o reservados a Tanca. Sendo proibida qualquer forma de reprodu&ccedil;&atilde;o e/ou distribui&ccedil;&atilde;o, sem autoriza&ccedil;&atilde;o pr&eacute;via da Tanca. Os dados presentes neste material est&atilde;o sujeitos a altera&ccedil;&otilde;es sem aviso pr&eacute;vio.</p>
<p style="text-align: justify;">A Tanca n&atilde;o assume responsabilidades quanto a erros, imprecis&otilde;es ou omiss&otilde;es em seu conte&uacute;do, bem como, qualquer outro tipo de dano, perda ou lucro cessado decorrente do uso dos dados contidos neste manual ou no arquivo da DLL disponibilizada.</p>
<p><strong>&nbsp;</strong><strong>&nbsp;</strong></p>
<h1><strong>Sum&aacute;rio</strong></h1>
<p>&nbsp;</p>
<p><strong><a href="#_Toc47360310">MANUAL DE DESENVOLVIMENTO.. 1</a></strong></p>
<p><strong><a href="#_Toc47360311">INTRODU&Ccedil;&Atilde;O.. 4</a></strong></p>
<p><strong><a href="#_Toc47360312">ESPECIFICA&Ccedil;&Atilde;O T&Eacute;CNICA E DETALHAMENTO DAS FUN&Ccedil;&Otilde;ES DA DLL. 4</a></strong></p>
<p><strong><a href="#_Toc47360313">INICIALIZA&Ccedil;&Atilde;O DO SERVI&Ccedil;O.. 5</a></strong></p>
<p><strong><a href="#_Toc47360314">INICIALIZA&Ccedil;&Atilde;O DO APLICA&Ccedil;&Atilde;O.. 5</a></strong></p>
<p><strong><a href="#_Toc47360315">LISTA DE TERMINAIS. 6</a></strong></p>
<p><strong><a href="#_Toc47360316">FORMATANDO ENDERE&Ccedil;AMENTO.. 9</a></strong></p>
<p><strong><a href="#_Toc47360317">ENVIANDO MENSAGENS DO APLICA&Ccedil;&Atilde;O PARA O TERMINAL. 10</a></strong></p>
<p><strong><a href="#_Toc47360318">ROTINA DE VERIFICA&Ccedil;&Atilde;O DE PRODUTO POR C&Oacute;DIGOS DE BARRAS. 35</a></strong></p>
<p><strong><a href="#_Toc47360319">IDENTIFICA&Ccedil;&Atilde;O DA VERS&Atilde;O DA DLL. 38</a></strong></p>
<p><strong><a href="#_Toc47360320">FINALIZA&Ccedil;&Atilde;O DO SERVI&Ccedil;O.. 38</a></strong></p>
<p><strong><a href="#_Toc47360321">SUPORTE T&Eacute;CNICO.. 39</a></strong></p>
<p>&nbsp;<strong>&nbsp;</strong></p>
<h2><a name="_Toc47360311"></a><strong>INTRODU&Ccedil;&Atilde;O</strong></h2>
<p><strong>&nbsp;</strong></p>
<p style="text-align: justify;">O presente conte&uacute;do vem como ferramenta de apoio ao desenvolvimento de solu&ccedil;&otilde;es para os Verificadores de Pre&ccedil;o produzidos pela Tanca. A partir deste material, ser&aacute; poss&iacute;vel reconhecer os nomes, finalidades, tipos de entradas e tipos de retornos das fun&ccedil;&otilde;es presentes na DLL (Dynamic Link Library) disponibilizada (VP_v3.dll).</p>
<p style="text-align: justify;">&nbsp;Possibilitando o desenvolvimento de sistemas, independente da linguagem de programa&ccedil;&atilde;o e da base de dados, contanto que essas tecnologias permitam o consumo deste tipo de recurso externo.</p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></p>
<h2><a name="_Toc47360312"></a><strong>ESPECIFICA&Ccedil;&Atilde;O T&Eacute;CNICA E DETALHAMENTO DAS FUN&Ccedil;&Otilde;ES DA DLL</strong></h2>
<p style="text-align: justify;"><strong>&nbsp;</strong><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>A DLL foi desenvolvida em linguagem Pascal, utilizando IDE Delphi vs 10. Portanto deve-se ter em mente que os tipos de retorno dessas fun&ccedil;&otilde;es devem ser analisados e o uso de recursos como bibliotecas, convers&otilde;es e outros, espec&iacute;ficos da linguagem e IDE que ser&aacute; utilizada no desenvolvimento da aplica&ccedil;&atilde;o (Servidor) que consumir&aacute; essa DLL, sejam respeitados, assim como as limita&ccedil;&otilde;es inerentes as mesmas.</p>
<p style="text-align: justify;">&nbsp;Os Terminais de Verifica&ccedil;&atilde;o de Pre&ccedil;o dever&atilde;o estar devidamente instalados na rede (TCP/IP) do local em a aplica&ccedil;&atilde;o ser&aacute; utilizada. Essa aplica&ccedil;&atilde;o funcionar&aacute; como Servidor, ponte entre a base de dados de produtos a serem pesquisados, que reconhecer&aacute; os Terminais conectados &agrave; rede, bem como as solicita&ccedil;&otilde;es encaminhadas por estes, tendo como apoio as fun&ccedil;&otilde;es da DLL. O consumo da DLL, n&atilde;o depende do dom&iacute;nio do protocolo, mas do conhecimento dos nomes, entradas e sa&iacute;das das fun&ccedil;&otilde;es da DLL. O Servi&ccedil;o proposto pela DLL consiste em gerenciar a comunica&ccedil;&atilde;o com os Terminais de Consulta (Verificadores de Pre&ccedil;o), atrav&eacute;s da porta 6500.</p>
<p style="text-align: justify;">Para melhor compreens&atilde;o do uso dessas fun&ccedil;&otilde;es, segue o detalhamento de FINALIDADE, ENTRADA e SA&Iacute;DA, bem como exemplos de declara&ccedil;&otilde;es em Pascal (Delphi), C++ e C#.</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<h3><a name="_Toc47360313"></a><strong><u>INICIALIZA&Ccedil;&Atilde;O DO SERVI&Ccedil;O</u></strong></h3>
<p>&nbsp;</p>
<p>Para que essa comunica&ccedil;&atilde;o seja inicializada pela aplica&ccedil;&atilde;o, a mesma dever&aacute; fazer uso das fun&ccedil;&otilde;es da DLL &ldquo;<strong>vInitialize</strong>&rdquo; e &ldquo;<strong>tc_startserver</strong>&rdquo;:</p>
<p>&nbsp;</p>
<ul>
<li><strong>vInitialize</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi: <strong>procedure vInitialize; stdcall; far;</strong></p>
<p>C++:&nbsp;&nbsp;&nbsp;&nbsp; <strong>void __stdcall bInitialize(void);</strong></p>
<p>C#:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<strong>public static extern void vInitialize();</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Primeira rotina que deve ser chamada para inicializar a DLL;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;N/A;</p>
<p><u>Sa&iacute;da</u>: &nbsp;N/A;</p>
<p>&nbsp;</p>
<h3><a name="_Toc47360314"></a><strong><u>INICIALIZA&Ccedil;&Atilde;O DO </u></strong><strong><u>SERVIDOR</u></strong></h3>
<p>&nbsp;</p>
<ul>
<li><strong>tc_startserver</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi: <strong>function&nbsp; tc_startserver: integer; stdcall; far;</strong></p>
<p>C++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>int __stdcall tc_startserver(void);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static extern int tc_startserver();</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Rotina que faz com que a aplica&ccedil;&atilde;o espere por conex&otilde;es de terminais;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;N/A;</p>
<p><u>Sa&iacute;da</u>: (<strong>int</strong>): Retorna <strong>1</strong> se a <u>aplica&ccedil;&atilde;o</u> foi inicializada com sucesso ou retorna <strong>0</strong> se houve erro.</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<h3><a name="_Toc47360315"></a><strong><u>LISTA DE TERMINAIS</u></strong></h3>
<p>&nbsp;</p>
<p style="text-align: justify;">Para o controle de quais terminais est&atilde;o ou n&atilde;o conectados na rede, pode-se utilizar da fun&ccedil;&atilde;o &ldquo;<strong>GetTabConectados</strong>&rdquo; que faz uso de refer&ecirc;ncias como a &ldquo;TTABSOCK&rdquo;, ou, caso queira controlar essas informa&ccedil;&otilde;es pelas fun&ccedil;&otilde;es &ldquo;<strong>bConnected </strong>&rdquo;, &ldquo;<strong>bDisconnected</strong>&rdquo; e &ldquo;<strong>bCloseTerminal</strong>&rdquo;, dever&aacute; elaborar uma forma de controlar a sua lista de terminais, seja por tabela, listagem ou at&eacute; mesmo enviando apenas os endere&ccedil;os para a grid do formul&aacute;rio, fica a crit&eacute;rio, assim n&atilde;o ter&aacute; depend&ecirc;ncia de uso da estrutura TTABSOCK, mas deve-se ter em mente o seu formato, para replicar essas informa&ccedil;&otilde;es de maneira coerente e completa.</p>
<p style="text-align: justify;">O uso de uma abordagem de controle ou outra depender&aacute; da tratativa de dados e compatibilidade de tipagens inerentes a linguagem escolhida para o desenvolvimento da aplica&ccedil;&atilde;o e do comportamento da mesma em rela&ccedil;&atilde;o aos terminais.</p>
<p style="text-align: justify;">&nbsp;</p>
<ul>
<li><strong>GetTabConectados</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi: <strong>function&nbsp; GetTabConectados(nada: integer): TTABSOCK; stdcall; far;</strong></p>
<p><strong>&nbsp;</strong></p>
<p>type</p>
<p>&nbsp; PTABCLI = ^TTABCLI;</p>
<p>&nbsp; TTABCLI = packed record</p>
<p>&nbsp;&nbsp;&nbsp; TabPort&nbsp;&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of Word;</p>
<p>&nbsp;&nbsp;&nbsp; TabSIP&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of String;</p>
<p>&nbsp;&nbsp;&nbsp; TabWIP&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of DWORD;</p>
<p>&nbsp;&nbsp;&nbsp; TabID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of integer;</p>
<p>&nbsp;&nbsp;&nbsp; TabIndex&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of integer;</p>
<p>&nbsp;&nbsp;&nbsp; TabHandle&nbsp;&nbsp; : array[0..MAX_TERMS-1] of integer;</p>
<p>&nbsp;&nbsp;&nbsp; TabCmdSent&nbsp; : array[0..MAX_TERMS-1] of integer;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; TabLiveTime : array[0..MAX_TERMS-1] of integer;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; TabTimeOut&nbsp; : array[0..MAX_TERMS-1] of integer;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; TabModelo&nbsp;&nbsp; : array[0..MAX_TERMS-1] of String;</p>
<p>&nbsp;&nbsp;&nbsp; TabVersao&nbsp;&nbsp; : array[0..MAX_TERMS-1] of String;</p>
<p>&nbsp;&nbsp;&nbsp; TabBarCode&nbsp; : array[0..MAX_TERMS-1] of String;</p>
<p>&nbsp;&nbsp;&nbsp; TabThread&nbsp;&nbsp; : array[0..MAX_TERMS-1] of Pointer;</p>
<p>&nbsp;&nbsp;&nbsp; TabValido&nbsp;&nbsp; : array[0..MAX_TERMS-1] of Boolean;</p>
<p>&nbsp;&nbsp;&nbsp; TabView&nbsp;&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of Boolean;</p>
<p>&nbsp;&nbsp;&nbsp; NumSockConec:integer;</p>
<p>&nbsp; end;</p>
<p>&nbsp;</p>
<p>type</p>
<p>&nbsp; PTABSOCK = ^TTABSOCK;</p>
<p>&nbsp; TTABSOCK = packed record</p>
<p>&nbsp;&nbsp;&nbsp; TabSock&nbsp;&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of Word;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; TabWIP&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : array[0..MAX_TERMS-1] of DWORD;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; NumSockConec:integer;</p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Retornar uma estrutura com a lista de terminais conectados;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;<strong>nada (int) </strong>reservada, deve haver ao menos 1;</p>
<p><u>Sa&iacute;da</u>: &nbsp;&nbsp;&nbsp;&nbsp;<strong>TTABSOCK;</strong></p>
<p>&nbsp;</p>
<p>- TabSock (int&nbsp;&nbsp; (array de 1024)): lista com os SOCKETs dos terminais.</p>
<p>- TabIP&nbsp;&nbsp; (DWORD (array de 1024)): lista com os IPs dos terminais.</p>
<p>- NumSockConec (int)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : n&uacute;mero de terminais conectados.</p>
<p>&nbsp;</p>
<p><strong><u>OU</u></strong></p>
<p>&nbsp;</p>
<ul>
<li><strong>bConnected</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi: <strong>function&nbsp; bConnected(out ID_IP: DWORD; out ID_Socket: word): boolean; far; stdcall;</strong></p>
<p>C++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>bool __stdcall bConnected(DWORD ID_IP, word ID_Socket);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static unsafe extern bool bConnected(out uint ID_IP, out ushort Porta);</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Verificar se houve a conex&atilde;o de um novo terminal na aplica&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;N/A;</p>
<p><u>Sa&iacute;da</u>: (<strong>bool</strong>), <strong>ID_IP</strong>, <strong>ID_Socket</strong> : Caso um novo terminal tenha se conectado a aplica&ccedil;&atilde;o, retornar&aacute; <strong>TRUE</strong>, o <strong>IP</strong> do terminal e <strong>Porta</strong> em que o mesmo se conectou, caso contr&aacute;rio retornar&aacute; <strong>FALSE</strong>;</p>
<p>&nbsp;</p>
<p>- ID_IP (DWORD): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal</p>
<p>- ID_Socket (word): valor num&eacute;rico da porta de comunica&ccedil;&atilde;o com o terminal</p>
<p>&nbsp;</p>
<ul>
<li><strong>bDisconnected</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi: <strong>function&nbsp; bDisconnected(out ID_IP: DWORD; out ID_Socket: word): boolean; far; stdcall;</strong></p>
<p>C++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>bool __stdcall bConnected(DWORD ID_IP, word ID_Socket);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static extern unsafe bool bDisconnected(out uint ID_IP, out ushort ID_Socket);</strong></p>
<p><strong>&nbsp;</strong></p>
<p><u>Finalidade</u>: Verificar se algum terminal se desconectou da aplica&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;N/A;</p>
<p><u>Sa&iacute;da</u>: (<strong>bool</strong>), <strong>ID_IP</strong>, <strong>ID_Socket</strong> : Caso um novo terminal tenha se desconectado da aplica&ccedil;&atilde;o, retornar&aacute; <strong>TRUE</strong>, o <strong>IP</strong> do terminal e <strong>Porta</strong> que o mesmo se desconectou, caso contr&aacute;rio retornar&aacute; <strong>FALSE</strong>;</p>
<p>&nbsp;</p>
<p>- ID_IP (DWORD): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal</p>
<p>- ID_Socket (word): valor num&eacute;rico da porta de comunica&ccedil;&atilde;o com o terminal</p>
<p>&nbsp;</p>
<ul>
<li><strong>bCloseTerminal</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; bCloseTerminal(ID_IP: DWORD; ID_Socket: Word): boolean; far; stdcall;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; bool __stdcall bCloseTerminal(DWORD ID_IP; word ID_Socket);</strong></p>
<p>C#:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>public static extern unsafe bool bCloseTerminal(uint ID_IP, ushort ID_Socket);</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Desconectar um determinado terminal, identificado atrav&eacute;s do endere&ccedil;o IP e porta de comunica&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p><u>Entrada: </u><strong>ID_IP, ID_Socket</strong>;</p>
<p>&nbsp;</p>
<p>- ID_IP (DWORD): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal</p>
<p>- ID_Socket (word): valor num&eacute;rico da porta de comunica&ccedil;&atilde;o com o terminal</p>
<p>&nbsp;</p>
<p><u>Sa&iacute;da</u>: (<strong>bool</strong>): Caso o terminal seja desconectado com sucesso, retornar&aacute; <strong>TRUE</strong>, caso contr&aacute;rio, retornar&aacute; <strong>FALSE</strong>;</p>
<p>&nbsp;</p>
<h3><a name="_Toc47360316"></a><strong><u>FORMATANDO ENDERE&Ccedil;AMENTO</u></strong></h3>
<p>&nbsp;</p>
<p style="text-align: justify;">A aplica&ccedil;&atilde;o poder&aacute; consumir as fun&ccedil;&otilde;es auxiliares &rdquo;<strong>Inet_NtoA</strong>&ldquo; e &ldquo;<strong>Inet_Addr</strong>&rdquo;, que formatam o endere&ccedil;amento dos Terminais, seja para serem usadas em apresenta&ccedil;&otilde;es de mensagens tratadas ou em outras fun&ccedil;&otilde;es da DLL consumidas pela aplica&ccedil;&atilde;o.</p>
<p>&nbsp;</p>
<ul>
<li><strong>Inet_NtoA</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function Inet_NtoA(ID_IP: DWORD): PAnsiChar; far; stdcall</strong><strong>;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;char* __stdcall Inet_NtoA(DWORD ID_IP);</strong></p>
<p>C#:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>public static extern unsafe IntPtr Inet_NtoA(uint ID_IP);</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Converte o n&uacute;mero de um IP de formato DWORD em um endere&ccedil;o IP no formato string (XXX.XXX.XXX.XXX);</p>
<p>&nbsp;</p>
<p><u>Entrada: </u><strong>ID_IP</strong> (<strong>DWORD</strong>): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal;</p>
<p><u>Sa&iacute;da</u>: (<strong>char *</strong>): ponteiro de string de endere&ccedil;o de rede (IP) do terminal;</p>
<p>&nbsp;</p>
<ul>
<li><strong>Inet_Addr</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; Inet_Addr(sIP: PAnsiChar): DWORD; far; stdcall;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;DWORD __stdcall Inet_Addr(char *sIP);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;public static extern unsafe uint Inet_Addr(IntPtr sIP);</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Converte endere&ccedil;o IP no formato string (XXX.XXX.XXX.XXX) em n&uacute;mero de um IP de formato DWORD;</p>
<p>&nbsp;</p>
<p><u>Entrada: </u><strong>sIP</strong> (<strong>char *</strong>): ponteiro de string de endere&ccedil;o de rede (IP) do terminal;</p>
<p><u>Sa&iacute;da</u>: (<strong>DWORD</strong>): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal;</p>
<p>&nbsp;</p>
<h3><a name="_Toc47360317"></a><strong><u>ENVIANDO MENSAGENS DO SERVIDOR PARA O TERMINAL</u></strong></h3>
<p>&nbsp;</p>
<p>Mensagens instant&acirc;neas podem ser enviadas para as linhas 1 e 2 do Terminal atrav&eacute;s da fun&ccedil;&atilde;o &ldquo;<strong>bSendDisplayMsg</strong>&rdquo;:</p>
<p>&nbsp;</p>
<ul>
<li><strong>bSendDisplayMsg</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; bSendDisplayMsg(ID_IP: DWORD; Linha1: PAnsiChar; Linha2: PAnsiChar; Tempo: Integer): Boolean; stdcall; far;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;bool __stdcall bSendDisplayMsg(DWORD ID_IP, char *Linha1, char *Linha2, int Tempo);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static extern unsafe bool bSendDisplayMsg(uint ID_IP, IntPtr Linha1, IntPtr Linha2, int Tempo)</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Enviar mensagem para as linhas 1 e 2 do terminal;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> <strong>ID_IP</strong> (<strong>DWORD</strong>), <strong>Linha1 </strong>(<strong>char *</strong>), <strong>Linha2 </strong>(<strong>char *</strong>) e <strong>Tempo</strong> (<strong>int</strong>):</p>
<p>&nbsp;</p>
<p>- ID_IP (DWORD): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal;</p>
<p>- Linha1 (char *): ponteiro de string que representa a primeira linha do display</p>
<p>- Linha2 (char *): ponteiro de string que representa a segunda linha do display</p>
<p>- Tempo (int): Tempo de exibi&ccedil;&atilde;o da mensagem, em segundos</p>
<p>&nbsp;</p>
<p><u>Sa&iacute;da</u>: (<strong>bool</strong>) : Caso a mensagem seja encaminhada com sucesso, retornar&aacute; <strong>TRUE</strong>, caso contr&aacute;rio, retornar&aacute; <strong>FALSE</strong>;</p>
<p>&nbsp;</p>
<p style="text-align: justify;">&nbsp; &nbsp; &nbsp; &nbsp; Assim que a conex&atilde;o entre o Terminal e a aplica&ccedil;&atilde;o &eacute; estabelecida, a aplica&ccedil;&atilde;o apresentar&aacute; um di&aacute;logo &ldquo;<strong>#ok</strong>&rdquo;, confirmando que sua conex&atilde;o foi aceita. O Terminal deve responder informando o prefixo &ldquo;#&rdquo; e os dados de <strong>modelo</strong> e <strong>vers&atilde;o</strong> separados por pipe, ex: &ldquo;<strong>#MODELO|1.23</strong>&rdquo; (Obs: esse formato permite a compatibilidade com equipamentos de outras fabricantes na mesma rede).</p>
<p style="text-align: justify;">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;A partir do momento que as fun&ccedil;&otilde;es de inicializa&ccedil;&atilde;o s&atilde;o utilizadas e &eacute; detectado que houve conex&atilde;o de um novo terminal, de maneira autom&aacute;tica, a aplica&ccedil;&atilde;o passar&aacute; a estabelecer um di&aacute;logo com o terminal enviando o comando &ldquo;<strong>#live?</strong>&rdquo;, a cada 10 segundos, de verifica&ccedil;&atilde;o de disponibilidade. Em resposta a aplica&ccedil;&atilde;o, o Terminal responder&aacute; &ldquo;<strong>#live</strong>&rdquo;. Se o intervalo de tempo, entre o comando &ldquo;#live?&rdquo; e a resposta &ldquo;#live&rdquo; exceder 30 segundos, a conex&atilde;o com este terminal ser&aacute; fechada automaticamente. &nbsp;Note que todo o procedimento acima &eacute; controlado internamente pela DLL.</p>
<p style="text-align: justify;">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&Eacute; poss&iacute;vel utilizar ainda de outros comandos da DLL para o Terminal atrav&eacute;s da aplica&ccedil;&atilde;o, segue a tabela completa de comandos e suas refer&ecirc;ncias:</p>
<p>&nbsp;</p>
<table width="0">
<tbody>
<tr>
<td colspan="3" width="586">
<p><strong>TABELA DE COMANDOS DO APLICA&Ccedil;&Atilde;O</strong></p>
</td>
</tr>
<tr>
<td width="163">
<p><strong>COMANDO</strong></p>
</td>
<td width="183">
<p><strong>RETORNO</strong></p>
</td>
<td width="239">
<p><strong>REFER&Ecirc;NCIA</strong></p>
</td>
</tr>
<tr>
<td width="163">
<p>#ok</p>
</td>
<td width="183">
<p>#modelo|versao</p>
</td>
<td width="239">
<p>Aplica&ccedil;&atilde;o envia para o Terminal o comando &ldquo;#ok&rdquo;, confirmando que sua conex&atilde;o foi aceita. O Terminal deve ent&atilde;o responder informando o prefixo &ldquo;#&rdquo; e os dados de modelo e vers&atilde;o separados por pipe, ex: &ldquo;#MODELO|1.23&rdquo;</p>
</td>
</tr>
<tr>
<td width="163">
<p>#live?</p>
</td>
<td width="183">
<p>#live</p>
</td>
<td width="239">
<p>Aplica&ccedil;&atilde;o verificando se o terminal est&aacute; &ldquo;vivo&rdquo; (conectado).</p>
</td>
</tr>
<tr>
<td width="163">
<p>#alwayslive</p>
</td>
<td width="183">
<p>#alwayslive_ok</p>
</td>
<td width="239">
<p>Desativa desconex&atilde;o com aplica&ccedil;&atilde;o. Ao enviar este comando, o terminal n&atilde;o fecha a conex&atilde;o com o aplica&ccedil;&atilde;o se este deixar de enviar algum comando por mais de 30 segundos.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#checklive</p>
</td>
<td width="183">
<p>#checklive_ok</p>
</td>
<td width="239">
<p>Ativa desconex&atilde;o com aplica&ccedil;&atilde;o. Este comando &eacute; o inverso do anterior, ou seja, ao envi&aacute;-lo, o terminal se desconecta do aplica&ccedil;&atilde;o se ficar mais de 30 segundos sem receber uma mensagem.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#restartsoft</p>
</td>
<td width="183">
<p>#restartsoft_ok</p>
</td>
<td width="239">
<p>Salva configura&ccedil;&otilde;es e reinicia terminal. Enviando este comando, o terminal &eacute; reiniciado. Uma boa sugest&atilde;o seria envi&aacute;-lo ap&oacute;s trocar seu IP (pela configura&ccedil;&atilde;o remota), para que a configura&ccedil;&atilde;o seja efetuada com sucesso imediatamente. A senha &eacute; um <em>longword</em> (4 bytes) que devem ser enviados para que o terminal realize este comando, a senha &eacute; a seguinte (em hexa): 0xA5CC5A33.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#updatesoft + "senha"</p>
</td>
<td width="183">
<p>#updatesoft_ok</p>
</td>
<td width="239">
<p>Responde, mas n&atilde;o realiza nenhuma outra a&ccedil;&atilde;o (compatibilidade). A senha &eacute; ignorada.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#config?</p>
</td>
<td width="183">
<p>#config "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM L2" "LINHA2" &ldquo;TEMPO"</p>
</td>
<td width="239">
<p>Retorna par&acirc;metros de configura&ccedil;&atilde;o incluindo apenas as linhas 1 e 2. O terminal responde com os seguintes dados:</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (byte): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (byte): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (byte): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong>(byte): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong>(<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong>(byte): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TEMPO</strong> (byte): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, deve-se subtrair 48 do valor de cada byte e n&atilde;o incluir as aspas duplas no retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#config02?</p>
</td>
<td width="183">
<p>#config02 "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP</p>
<p>TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM</p>
<p>L2" "LINHA2" "TAM L3" "LINHA3" "TAM L4" "LINHA4" "TEMPO"</p>
</td>
<td width="239">
<p>Retorna par&acirc;metros de configura&ccedil;&atilde;o incluindo todas as linhas. O terminal responde com os seguintes dados:</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (byte): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (byte): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM L3</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 3;</p>
<p><strong>LINHA3</strong> (<em>string</em>): texto da linha 3;</p>
<p><strong>TAM L4</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 4;</p>
<p><strong>LINHA4</strong> (<em>string</em>): texto da linha 4;</p>
<p><strong>TEMPO</strong> (byte): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, deve-se subtrair 48 do valor de cada byte e n&atilde;o incluir as aspas duplas no retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#conf502?</p>
</td>
<td width="183">
<p>#config502 "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP</p>
<p>TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM</p>
<p>L2" "LINHA2" "TAM L3" "LINHA3" "TAM L4" "LINHA4" "TEMPO"</p>
</td>
<td width="239">
<p>Retorna par&acirc;metros de configura&ccedil;&atilde;o incluindo todas as linhas. O terminal responde com os seguintes dados:</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM L3</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 3;</p>
<p><strong>LINHA3</strong> (<em>string</em>): texto da linha 3;</p>
<p><strong>TAM L4</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 4;</p>
<p><strong>LINHA4</strong> (<em>string</em>): texto da linha 4;</p>
<p><strong>TEMPO</strong> (<em>byte</em>): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, deve-se subtrair 48 do valor de cada byte e n&atilde;o incluir as aspas duplas no retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#updconfig?</p>
</td>
<td width="183">
<p>#updconfig "TAM GW" "GATEWAY" "TAM DNS" "DNS" "TAM TERM" "TERM" "TAM NS" "NS" "TAM NS" "NS" "TAM NS" "NS"</p>
</td>
<td width="239">
<p>Retorna par&acirc;metros de configura&ccedil;&atilde;o incluindo gateway, dns e nome do terminal:</p>
<p>&nbsp;</p>
<p><strong>TAM GW </strong>(<em>byte</em>): tamanho da <em>string</em> do Gateway;</p>
<p><strong>GATEWAY</strong> (<em>string</em>): Gateway;</p>
<p><strong>TAM DNS</strong> (<em>byte</em>): tamanho da <em>string</em> do DNS;</p>
<p><strong>DNS</strong> (<em>string</em>): DNS;</p>
<p><strong>TAM TERM</strong> (<em>byte</em>): tamanho da <em>string</em> do nome do terminal;</p>
<p><strong>TERM</strong> (<em>string</em>): Nome;</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> devemos subtrair 48 (<em>decimal</em>) do valor de cada byte.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#updconfig + "dados"</p>
</td>
<td width="183">
<p>#updconfig_ok</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o dados: "TAM GW" "GATEWAY" "TAM DNS" "DNS" "TAM TERM" "TERM" "TAM NS" "NS" "TAM NS" "NS" "TAM NS" "NS":</p>
<p>&nbsp;</p>
<p><strong>TAM GW</strong> (<em>byte</em>): tamanho da <em>string</em> do Gateway;</p>
<p><strong>GATEWAY</strong> (<em>string</em>): Gateway;</p>
<p><strong>TAM DNS</strong> (<em>byte</em>): tamanho da <em>string</em> do DNS;</p>
<p><strong>DNS</strong> (<em>string</em>): DNS;</p>
<p><strong>TAM TERM</strong> (<em>byte</em>): tamanho da <em>string</em> do nome do terminal;</p>
<p><strong>TERM</strong> (<em>string</em>): Nome;</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (decimal);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (decimal);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> devemos subtrair 48(<em>decimal</em>) do valor de cada <em>byte</em>.</p>
</td>
</tr>
<tr>
<td width="163">
<p>rupdconfig + "dados"</p>
</td>
<td width="183">
<p>&nbsp;</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o dados: "TAM GW" "GATEWAY" "TAM DNS" "DNS" "TAM TERM" "TERM" "TAM NS" "NS" "TAM NS" "NS" "TAM NS" "NS":</p>
<p>&nbsp;</p>
<p><strong>TAM GW</strong> (<em>byte</em>): tamanho da <em>string</em> do Gateway;</p>
<p><strong>GATEWAY</strong> (<em>string</em>): Gateway;</p>
<p><strong>TAM DNS</strong> (<em>byte</em>): tamanho da <em>string</em> do DNS;</p>
<p><strong>DNS</strong> (<em>string</em>): DNS;</p>
<p><strong>TAM TERM</strong> (<em>byte</em>): tamanho da <em>string</em> do nome do terminal;</p>
<p><strong>TERM</strong> (<em>string</em>): Nome;</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> devemos subtrair 48 (<em>decimal</em>) do valor de cada <em>byte</em>.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#extconfig?</p>
</td>
<td width="183">
<p>#extconfig "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM GW" "GATEWAY" "TAM NS" "NS" "TAM TERM" "TERM" "TAM L1" "LINHA1" "TAM L2" "LINHA2" "TAM NS" "NS" "TAM NS" "NS" "TAM NS" "NS" "TEMPO" "DHCP" "RESERVADO"</p>
</td>
<td width="239">
<p>Retorna par&acirc;metros de configura&ccedil;&atilde;o estendidos:</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM GW</strong> (<em>byte</em>): tamanho da <em>string</em> do Gateway;</p>
<p><strong>GATEWAY</strong> (<em>string</em>): Gateway;</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM TERM</strong> (<em>byte</em>): tamanho da <em>string</em> do nome do terminal;</p>
<p><strong>TERM</strong> (<em>string</em>): Nome;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto a linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TEMPO</strong> (<em>byte</em>): Tempo de Exibi&ccedil;&atilde;o;</p>
<p><strong>DHCP</strong> (<em>byte</em>): IP din&acirc;mico/fixo (48 = fixo, 49 = din&acirc;mico);</p>
<p><strong>RESERVADO</strong> (<em>byte</em>): 48 (<em>decimal</em>);</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, devemos subtrair 48 (<em>decimal</em>) do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#rconf + "dados"</p>
</td>
<td width="183">
<p>&nbsp;</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o: "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM L2" "TEMPO".</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TEMPO</strong> (<em>byte</em>): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#reconf02 + "dados"</p>
</td>
<td width="183">
<p>&nbsp;</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o: "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM L2" "LINHA2" "TAM L3" "LINHA3" "TAM L4" "LINHA4" "TEMPO".</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM L3</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 3;</p>
<p><strong>LINHA3</strong> (<em>string</em>): texto da linha 3;</p>
<p><strong>TAM L4</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 4;</p>
<p><strong>LINHA4</strong> (<em>string</em>): texto da linha 4;</p>
<p><strong>TEMPO</strong> (<em>byte</em>): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#rconfig + "dados"</p>
</td>
<td width="183">
<p>&nbsp;</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o: "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM L2" "LINHA2" "TAM L3" "LINHA3" "TAM L4" "LINHA4" "TEMPO"</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM L3</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 3.</p>
<p><strong>LINHA3</strong> (<em>string</em>): texto da linha 3;</p>
<p><strong>TAM L4</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 4;</p>
<p><strong>LINHA4</strong> (<em>string</em>): texto da linha 4;</p>
<p><strong>TEMPO</strong> (<em>byte</em>): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#rconf02 + "dados"</p>
</td>
<td width="183">
<p>&nbsp;</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o: "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM L2" "LINHA2" "TAM L3" "LINHA3" "TAM L4" "LINHA4" "TEMPO"</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM L3</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 3;</p>
<p><strong>LINHA3</strong> (<em>string</em>): texto da linha 3;</p>
<p><strong>TAM L4</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 4;</p>
<p><strong>LINHA4</strong> (<em>string</em>): texto da linha 4;</p>
<p><strong>TEMPO</strong> (<em>byte</em>): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#reconf502 + "dados"</p>
</td>
<td width="183">
<p>&nbsp;</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o: "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM L1" "LINHA1" "TAM L2" "LINHA2" "TAM L3" "LINHA3" "TAM L4" "LINHA4" "TEMPO"</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM L3</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 3;</p>
<p><strong>LINHA3</strong> (<em>string</em>): texto da linha 3;</p>
<p><strong>TAM L4</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 4;</p>
<p><strong>LINHA4</strong> (<em>string</em>): texto da linha 4;</p>
<p><strong>TEMPO</strong> (<em>byte</em>): tempo de exibi&ccedil;&atilde;o;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#rextconf + "dados"</p>
</td>
<td width="183">
<p>#rextconf_ok</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros estendidos: "TAM IP APLICA&Ccedil;&Atilde;O" "IP APLICA&Ccedil;&Atilde;O" "TAM IP TERMINAL" "IP TERMINAL" "TAM MASC" "MASCARA DE REDE" "TAM GW" "GATEWAY" "TAM NS" "NS" "TAM TERM" "TERM" "TAM L1" "LINHA1" "TAM L2" "LINHA2" "TAM NS" "NS" "TAM NS" "NS" "TAM NS" "NS" "TEMPO" "DHCP" "RESERVADO":</p>
<p>&nbsp;</p>
<p><strong>TAM IP APLICA&Ccedil;&Atilde;O</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do aplica&ccedil;&atilde;o;</p>
<p><strong>IP APLICA&Ccedil;&Atilde;O</strong> (<em>string</em>): IP do aplica&ccedil;&atilde;o;</p>
<p><strong>TAM IP TERMINAL</strong> (<em>byte</em>): tamanho da <em>string</em> do IP do terminal;</p>
<p><strong>IP TERMINAL</strong> (<em>string</em>): IP do terminal;</p>
<p><strong>TAM MASC</strong> (<em>byte</em>): tamanho da <em>string</em> da m&aacute;scara de rede;</p>
<p><strong>MASCARA DE REDE</strong> (<em>string</em>): m&aacute;scara de rede;</p>
<p><strong>TAM GW</strong> (<em>byte</em>): tamanho da <em>string</em> do Gateway;</p>
<p><strong>GATEWAY</strong> (<em>string</em>): Gateway;</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM TERM</strong> (<em>byte</em>): tamanho da <em>string</em> do nome do terminal;</p>
<p><strong>TERM</strong> (<em>string</em>): Nome;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> do texto a linha 1;</p>
<p><strong>LINHA1</strong> (<em>string</em>): texto da linha 1;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> do texto da linha 2;</p>
<p><strong>LINHA2</strong> (<em>string</em>): texto da linha 2;</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TAM NS</strong> (<em>byte</em>): 61 (<em>decimal</em>);</p>
<p><strong>NS</strong> (<em>string</em>): &ldquo;N&atilde;o suportado&rdquo; (sem as aspas);</p>
<p><strong>TEMPO</strong> (<em>byte</em>): Tempo de Exibi&ccedil;&atilde;o;</p>
<p><strong>DHCP</strong> (<em>byte</em>): IP din&acirc;mico/fixo(48 = fixo, 49 = din&acirc;mico);</p>
<p><strong>RESERVADO</strong> (<em>byte</em>): 48 (<em>decimal</em>);</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> ou do tempo de exibi&ccedil;&atilde;o, devemos subtrair 48 (<em>decimal</em>) do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#wlanconfig?</p>
</td>
<td width="183">
<p>#wlanconfig "WIFI ON" "MODO" "TAM SSID" "CANAL" "WEP ON" "TAM WEP" "CHAVE WEP"</p>
</td>
<td width="239">
<p>Retorna par&acirc;metros de configura&ccedil;&atilde;o do wifi.</p>
<p>&nbsp;</p>
<p><strong>WIFI ON</strong> (<em>byte</em>): 48 = Desabilita | 49 = Habilita WIFI;</p>
<p><strong>MODO</strong> (<em>byte</em>): Modo;</p>
<p><strong>TAM SSID</strong> (<em>byte</em>): Tamanho da <em>string</em> do SSID;</p>
<p><strong>SSID</strong> (<em>string</em>): SSID.</p>
<p><strong>CANAL </strong>(<em>byte</em>): Canal;</p>
<p><strong>WEP ON</strong> (<em>byte</em>): 48 = Desabilita | 49 = Desabilita WEP;</p>
<p><strong>TAM WEP</strong> (<em>byte</em>): Tamanho da <em>string</em> da chave WEP;</p>
<p><strong>CHAVE WEP</strong> (<em>string</em>): Chave WEP;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#rwlanconfig + "dados"</p>
</td>
<td width="183">
<p>#rwlanconfig_ok</p>
</td>
<td width="239">
<p>Recebe e carrega par&acirc;metros de configura&ccedil;&atilde;o do wifi: "WIFI ON" "MODO" "TAM SSID" "CANAL" "WEP ON" "TAM WEP" "CHAVE WEP"</p>
<p>&nbsp;</p>
<p><strong>WIFI ON</strong> (<em>byte</em>): 48 = Desabilita | 49 = Habilita WIFI;</p>
<p><strong>MODO</strong> (<em>byte</em>): Modo;</p>
<p><strong>TAM SSID</strong> (<em>byte</em>): Tamanho da <em>string</em> do SSID;</p>
<p><strong>SSID</strong> (<em>string</em>): SSID;</p>
<p><strong>CANAL</strong> (<em>byte</em>): Canal;</p>
<p><strong>WEP ON</strong> (<em>byte</em>): 48 = Desabilita | 49 = Desabilita WEP;</p>
<p><strong>TAM WEP</strong> (<em>byte</em>): Tamanho da <em>string</em> da chave WEP;</p>
<p><strong>CHAVE WEP</strong> (<em>string</em>): Chave WEP;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o tamanho real de cada <em>string</em> devemos subtrair 48 do valor de cada byte. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#paramconfig?</p>
</td>
<td width="183">
<p>#paramconfig "DHCP" "RESERVADO"</p>
</td>
<td width="239">
<p>Retorna par&acirc;metros relativos ao DHCP</p>
<p>&nbsp;</p>
<p><strong>DHCP</strong> (<em>byte</em>): 48 = DHCP desativado | 49 = DHCP ativado;</p>
<p><strong>RESERVADO</strong> (<em>byte</em>) = sempre dever&aacute; ser 48;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o valor real de cada campo, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#paramconfig + "dados"</p>
</td>
<td width="183">
<p>#paramconfig_ok</p>
</td>
<td width="239">
<p>Recebe e carrega os par&acirc;metros relativos ao DHCP: "DHCP" "RESERVADO":</p>
<p>&nbsp;</p>
<p><strong>DHCP</strong> (<em>byte</em>): 48 = DHCP desativado | 49 = DHCP ativado;</p>
<p><strong>RESERVADO</strong> (<em>byte</em>) = sempre dever&aacute; ser 48;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o valor real de cada campo, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#rparamconfig + "dados"</p>
</td>
<td width="183">
<p>#rparamconfig_ok</p>
</td>
<td width="239">
<p>Recebe e carrega os par&acirc;metros relativos ao DHCP: "DHCP" "RESERVADO":</p>
<p>&nbsp;</p>
<p><strong>DHCP</strong> (<em>byte</em>): 48 = DHCP desativado | 49 = DHCP ativado;</p>
<p><strong>RESERVADO</strong> (<em>byte</em>) = sempre dever&aacute; ser 48;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o valor real de cada campo, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#mesg + "params"</p>
</td>
<td width="183">
<p>&nbsp;</p>
</td>
<td width="239">
<p>Mostra mensagem recebida no display (2 linhas): "TAM L1" "LINHA1|TAM L2" "LINHA2"TEMPO" "RESERVADO":</p>
<p>&nbsp;</p>
<p><strong>TAM L1</strong> (<em>byte</em>): tamanho da <em>string</em> da mensagem da primeira linha;</p>
<p><strong>LINHA1</strong> (<em>string</em>): mensagem da primeira linha;</p>
<p><strong>TAM L2</strong> (<em>byte</em>): tamanho da <em>string</em> da mensagem da segunda linha;</p>
<p><strong>LINHA2</strong> (<em>string</em>): mensagem da segunda linha;</p>
<p><strong>TEMPO</strong> (<em>byte</em>): tempo de exibi&ccedil;&atilde;o;</p>
<p><strong>RESERVADO</strong> (<em>byte</em>): reservado, deve ser = 48;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o valor real de cada campo, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
<tr>
<td width="163">
<p>#macaddr? + "dados"</p>
</td>
<td width="183">
<p>#macaddr "INTERFACE" "TAM MAC" "MAC"</p>
</td>
<td width="239">
<p>Retorna o endere&ccedil;o MAC: "INTERFACE"</p>
<p>&nbsp;</p>
<p><strong>INTERFACE</strong> (<em>byte</em>): 48 = Ethernet | 49 = WiFi | 57 = Atual;</p>
<p><strong>TAM MAC</strong> (<em>byte</em>): Tamanho da <em>string</em> do endere&ccedil;o MAC;</p>
<p><strong>MAC</strong> (<em>string</em>): Endere&ccedil;o MAC;</p>
<p>&nbsp;</p>
<p>OBS: Para saber o valor real de cada campo, devemos subtrair 48 do valor de cada <em>byte</em>. N&atilde;o incluir as aspas duplas do retorno.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3><a name="_Toc47360318"></a><strong><u>ROTINA DE VERIFICA&Ccedil;&Atilde;O DE PRODUTO POR C&Oacute;DIGOS DE BARRAS</u></strong></h3>
<p>&nbsp;</p>
<p style="text-align: justify;">Ao efetuar a leitura de um c&oacute;digo de barras, o Terminal envia para a aplica&ccedil;&atilde;o o comando de pesquisa de c&oacute;digo de barras, com o prefixo &ldquo;<strong>#</strong>&rdquo;, seguido do valor de c&oacute;digo de barras lido, ex: &ldquo;#123&rdquo;. &nbsp;A aplica&ccedil;&atilde;o deve verificar periodicamente se h&aacute; novas solicita&ccedil;&otilde;es de pesquisa de c&oacute;digo de barras encaminhadas pelos terminais conectados. Isto &eacute; feito utilizando-se da fun&ccedil;&atilde;o &ldquo;<strong>bReceiveBarcode</strong>&rdquo;.</p>
<p style="text-align: justify;">Ao obter o c&oacute;digo de barras (ponteiro string) a aplica&ccedil;&atilde;o deve procurar em sua <u>base de dados</u> a exist&ecirc;ncia do valor referenciado pelo Terminal. Caso exista, deve retornar ao Terminal as informa&ccedil;&otilde;es de &ldquo;<strong>produto</strong>&rdquo; (linha 1) e &ldquo;<strong>pre&ccedil;o</strong>&rdquo; (linha 2) atrav&eacute;s da fun&ccedil;&atilde;o &ldquo;<strong>bSendProdPrice</strong>&rdquo;, ex: &ldquo;#Limao|2,00&rdquo;.</p>
<p style="text-align: justify;">Caso esse valor n&atilde;o exista na base de dados, a aplica&ccedil;&atilde;o dever&aacute; enviar uma mensagem para informar o Terminal que o produto n&atilde;o existe e utilizar a fun&ccedil;&atilde;o &ldquo;<strong>bSendProdNotFound</strong>&rdquo; para validar se o terminal recebeu essa mensagem ou n&atilde;o.</p>
<p>&nbsp;</p>
<ul>
<li><strong>bReceiveBarcode</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; bReceiveBarcode(out ID_IP: DWORD; out ID_Socket: word; out Nbr: integer): PAnsiChar; stdcall; far;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;char * --stdcall bReceiveBarcode(DWORD ID_IP, word ID_Socket, int Nbr);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static extern unsafe IntPtr bReceiveBarcode(out uint ID_IP, out ushort ID_Socket, out int Nbr);</strong></p>
<p><strong>&nbsp;</strong></p>
<p><u>Finalidade</u>: Usada periodicamente para identificar se houve solicita&ccedil;&atilde;o de pesquisa de c&oacute;digo de barras pendente. Caso haja, retornar&aacute; o c&oacute;digo de barras (ponteiro string), o endere&ccedil;o IP e a porta do terminal solicitante;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;N/A;</p>
<p><u>Sa&iacute;da</u>: (<strong>char *</strong>), <strong>ID_IP, ID_Socket, Nbr</strong></p>
<p>&nbsp;</p>
<p>- (char *): ponteiro de string com o c&oacute;digo de barras recebido</p>
<p>- ID_IP (DWORD): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal</p>
<p>- ID_Socket (word): valor num&eacute;rico da porta de comunica&ccedil;&atilde;o com o terminal</p>
<p>- Nbr (int): n&uacute;mero de dados do c&oacute;digo de barras (sempre ser&aacute; "1", pois o sistema analisa um c&oacute;digo de barras por vez);</p>
<p>&nbsp;</p>
<ul>
<li><strong>bSendProdNotFound</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; bSendProdNotFound(ID_IP: DWORD): boolean; far; stdcall;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;bool __stdcall bSendProdNotFound(DWORD ID_IP);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static extern unsafe bool bSendProdNotFound(uint ID_IP);</strong></p>
<p>&nbsp;</p>
<p><u>Finalidade</u>: Informar a aplica&ccedil;&atilde;o que o terminal solicitante recebeu a mensagem;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;<strong>ID_IP</strong> (<strong>DWORD</strong>): valor num&eacute;rico do endere&ccedil;o de rede (IP) do terminal;</p>
<p><u>Sa&iacute;da</u>: (<strong>bool</strong>): Caso o terminal receba a mensagem enviada pela aplica&ccedil;&atilde;o, retornar&aacute; <strong>TRUE</strong>, caso contr&aacute;rio, retornar&aacute; <strong>FALSE</strong>;</p>
<p>&nbsp;</p>
<ul>
<li><strong>bSendProdPrice</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; bSendProdPrice(ID_IP: DWORD; NameProd: PAnsiChar; PriceProd: PAnsiChar): Boolean; stdcall; far;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;bool __stdcall bSendProdPrice(DWORD ID_IP, char *NameProd, char *PriceProd);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static extern unsafe bool bSendProdPrice(UInt32 IP, IntPtr Prod, IntPtr Valor);</strong></p>
<p><strong>&nbsp;</strong></p>
<p><u>Finalidade</u>: Envia para a primeira e segunda linha do display do terminal solicitante o nome e o pre&ccedil;o do produto pesquisado;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;<strong>ID_IP</strong>, <strong>NameProd</strong>, <strong>PriceProd</strong>:</p>
<p>&nbsp;</p>
<p>- ID_IP (DWORD): valor num&eacute;rico de endere&ccedil;o de rede (IP) do terminal</p>
<p>- NameProd (char *) : ponteiro string com o nome do produto</p>
<p>- PriceProd (char *): ponteiro string com o pre&ccedil;o do produto</p>
<p>&nbsp;</p>
<p><u>Sa&iacute;da</u>: (<strong>bool</strong>) : Caso a mensagem seja encaminhada com sucesso, retornar&aacute; <strong>TRUE</strong>, caso contr&aacute;rio, retornar&aacute; <strong>FALSE</strong>;</p>
<h3><a name="_Toc47360319"></a><strong><u>IDENTIFICA&Ccedil;&Atilde;O DA VERS&Atilde;O DA DLL</u></strong></h3>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Refor&ccedil;ando que algumas fun&ccedil;&otilde;es podem variar segundo a vers&atilde;o da DLL, caso tenha d&uacute;vidas quanto a vers&atilde;o da DLL utilizada, basta validar a fun&ccedil;&atilde;o &ldquo;<strong>dll_version</strong>&rdquo;:</p>
<p>&nbsp;</p>
<ul>
<li><strong>dll_version</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; dll_version: PAnsiChar; stdcall; far;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;char * __stdcall dll_version(void);</strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; static extern IntPtr dll_version();</strong></p>
<p><strong>&nbsp;</strong></p>
<p><u>Finalidade</u>: Retornar a vers&atilde;o da DLL;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;N/A;</p>
<p><u>Retorno</u>: (<strong>char *</strong>): ponteiro de string com o valor da vers&atilde;o da DLL.</p>
<p>&nbsp;</p>
<h3><a name="_Toc47360320"></a><strong><u>FINALIZA&Ccedil;&Atilde;O DO SERVI&Ccedil;O</u></strong></h3>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Por fim, para finalizar o servi&ccedil;o basta utilizar a fun&ccedil;&atilde;o &ldquo;<strong>bTerminate</strong>&rdquo;:</p>
<p>&nbsp;</p>
<ul>
<li><strong>bTerminate</strong></li>
</ul>
<p>&nbsp;</p>
<p>Delphi<strong>: function&nbsp; bTerminate: boolean; far; stdcall;</strong></p>
<p>C<strong>++:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;bool __stdcall bTerminate(void); </strong></p>
<p>C#:<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static extern bool bTerminate();</strong></p>
<p><strong>&nbsp;</strong></p>
<p><u>Finalidade</u>: &Uacute;ltima rotina chamada antes de finalizar servi&ccedil;o;</p>
<p>&nbsp;</p>
<p><u>Entrada:</u> &nbsp;N/A;</p>
<p><u>Retorno</u>: (<strong>bool</strong>) : Caso tenha sucesso, retornar&aacute; <strong>TRUE</strong>, caso contr&aacute;rio, retornar&aacute; <strong>FALSE</strong>;</p>
<h2><a name="_Toc47360321"></a><strong><u>SUPORTE T&Eacute;CNICO</u></strong></h2>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Em caso de d&uacute;vidas, entrar em contato atrav&eacute;s de solicita&ccedil;&atilde;o de suporte no canal <a href="https://servidorseguro.mysuite2.com.br/client/login.php?sl=tanc&amp;h=&amp;inf=&amp;lf=">SUPORTE TANCA</a>, nossa equipe est&aacute; disposi&ccedil;&atilde;o.</p>
