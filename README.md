<div class="my-2"></div>
<hr>
<h1>WalletAPI </h1>
<p><button class="block overflow-hidden min-h-[160px] w-fit max-h-[320px] min-w-[160px] max-w-[320px] rounded-lg"><img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="License" class="rounded-[20px]" draggable="false" data-cy="image"></button>   </p>
<div class="my-2"></div>
<h2>Descrição </h2>
<p>A <strong>WalletAPI </strong> é uma API RESTful desenvolvida em C# com ASP.NET Core para gerenciar carteiras digitais e transações financeiras. Ela permite que os usuários se cadastrem, autentiquem, consultem saldos, adicionem saldo às suas carteiras, realizem transferências entre usuários e consultem o histórico de transações. </p>
<div class="my-2"></div>
<p>A API utiliza autenticação JWT para proteger as rotas sensíveis e armazena os dados em um banco de dados MySQL. </p>
<div class="my-2"></div>
<hr>
<h2>Índice </h2>
<ol start="1">
    <li><a href="#estrutura-de-pastas" target="_blank" rel="nofollow" style="position: relative;">Estrutura de Pastas </a></li>
    <li><a href="#requisitos" target="_blank" rel="nofollow" style="position: relative;">Requisitos </a></li>
    <li><a href="#configuração-inicial" target="_blank" rel="nofollow" style="position: relative;">Configuração Inicial </a></li>
    <li><a href="#executando-o-projeto" target="_blank" rel="nofollow" style="position: relative;">Executando o Projeto </a></li>
    <li><a href="#rotas-da-api" target="_blank" rel="nofollow" style="position: relative;">Rotas da API </a></li>
    <li><a href="#scripts-e-comandos-úteis" target="_blank" rel="nofollow" style="position: relative;">Scripts e Comandos Úteis </a></li>
    <li><a href="#considerações-finais" target="_blank" rel="nofollow" style="position: relative;">Considerações Finais </a></li>
</ol>
<div class="my-2"></div>
<hr>
<h2>Estrutura de Pastas </h2>
<div>
    <div class="my-2 code-cntainer" dir="ltr">
        <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white"></div>
        <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
            <div class="flex translate-y-[1px] items-center gap-0.5">
                <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
            </div>
        </div>
        <div class="language-  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
            <div class="code-block-header"></div>
            <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-19" class="code-textarea h-full w-full ">
                <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                    <div class="cm-announced" aria-live="polite"></div>
                    <div tabindex="-1" class="cm-scroller">
                        <div class="cm-gutters" aria-hidden="true" style="min-height: 299.078px; position: sticky;">
                            <div class="cm-gutter cm-lineNumbers">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">99</div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">4</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">5</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">6</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">7</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">8</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">9</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">10</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">11</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">12</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">13</div>
                            </div>
                            <div class="cm-gutter cm-foldGutter">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"></div>
                            </div>
                        </div>
                        <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here...">
                            <div class="cm-activeLine cm-line">/WalletAPI</div>
                            <div class="cm-line">│</div>
                            <div class="cm-line">├── /Controllers          # Controladores da API (rotas e lógica HTTP)</div>
                            <div class="cm-line">├── /Data                 # Contexto do banco de dados e migrations</div>
                            <div class="cm-line">├── /DTOs                 # Objetos de transferência de dados (DTOs)</div>
                            <div class="cm-line">├── /Models               # Modelos de entidade (representação das tabelas no banco)</div>
                            <div class="cm-line">├── /Services             # Serviços de lógica de negócios (opcional, se necessário)</div>
                            <div class="cm-line">├── /Utils                # Utilitários (JWT, hashing, etc.)</div>
                            <div class="cm-line">├── appsettings.json      # Configurações da aplicação (string de conexão, JWT, etc.)</div>
                            <div class="cm-line">├── WalletAPI.csproj      # Arquivo de projeto</div>
                            <div class="cm-line">├── Program.cs            # Ponto de entrada da aplicação</div>
                            <div class="cm-line">├── README.md             # Documentação do projeto</div>
                            <div class="cm-line">└── database.sql          # Script SQL para criar o banco de dados e populá-lo</div>
                        </div>
                        <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                            <div class="cm-cursor cm-cursor-primary" style="left: 43.3594px; top: 5px; height: 19px;"></div>
                        </div>
                        <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-19" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
    </div>
</div>
<div class="my-2"></div>
<hr>
<h2>Requisitos </h2>
<p>Antes de executar o projeto, certifique-se de ter os seguintes requisitos instalados: </p>
<div class="my-2"></div>
<ul>
    <li><a href="https://dotnet.microsoft.com/download/dotnet/6.0" target="_blank" rel="nofollow" style="position: relative;">.NET 6 SDK </a> ou superior.</li>
    <li><a href="https://dev.mysql.com/downloads/mysql/" target="_blank" rel="nofollow" style="position: relative;">MySQL Server </a> instalado e configurado.</li>
    <li>Ferramenta para testar APIs, como <a href="https://www.postman.com/" target="_blank" rel="nofollow" style="position: relative;">Postman </a> ou <a href="https://insomnia.rest/" target="_blank" rel="nofollow" style="position: relative;">Insomnia </a>.</li>
</ul>
<div class="my-2"></div>
<hr>
<h2>Configuração Inicial </h2>
<h3>1. Clonar o Repositório </h3>
<p>Clone este repositório para sua máquina local: </p>
<div class="my-2"></div>
<div>
    <div class="my-2 code-cntainer" dir="ltr">
        <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">bash</div>
        <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
            <div class="flex translate-y-[1px] items-center gap-0.5">
                <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
            </div>
        </div>
        <div class="language-bash  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
            <div class="code-block-header"></div>
            <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-32" class="code-textarea h-full w-full ">
                <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                    <div class="cm-announced" aria-live="polite"></div>
                    <div tabindex="-1" class="cm-scroller">
                        <div class="cm-gutters" aria-hidden="true" style="min-height: 52.7812px; position: sticky;">
                            <div class="cm-gutter cm-lineNumbers">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                            </div>
                            <div class="cm-gutter cm-foldGutter">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"></div>
                            </div>
                        </div>
                        <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="shell" aria-autocomplete="list">
                            <div class="cm-activeLine cm-line"><span class="ͼs">git</span> clone https://github.com/seu-usuario/WalletAPI.git </div>
                            <div class="cm-line"><span class="ͼs">cd</span> WalletAPI</div>
                        </div>
                        <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                            <div class="cm-cursor cm-cursor-primary" style="left: 37.125px; top: 5px; height: 19px;"></div>
                        </div>
                        <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-32" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
    </div>
</div>
<div class="my-2"></div>
<h3>2. Configurar o Banco de Dados </h3>
<p>Execute o script <code class="codespan cursor-pointer z-[9] relative">database.sql</code> no seu servidor MySQL para criar o banco de dados e as tabelas necessárias. </p>
<div class="my-2"></div>
<p>Se você estiver usando o MySQL Workbench: </p>
<ol start="1">
    <li>Abra o MySQL Workbench.</li>
    <li>Conecte-se ao seu servidor MySQL.</li>
    <li>Execute o script <code class="codespan cursor-pointer z-[9] relative">database.sql</code>.</li>
</ol>
<div class="my-2"></div>
<p>O script criará: </p>
<ul>
    <li>Um banco de dados chamado <code class="codespan cursor-pointer z-[9] relative">WalletDB</code>.</li>
    <li>Duas tabelas: <code class="codespan cursor-pointer z-[9] relative">Users</code> e <code class="codespan cursor-pointer z-[9] relative">Transactions</code>.</li>
    <li>Dados fictícios para demonstração.</li>
</ul>
<div class="my-2"></div>
<h3>3. Configurar a String de Conexão </h3>
<p>Edite o arquivo <code class="codespan cursor-pointer z-[9] relative">appsettings.json</code> e configure a string de conexão para o seu banco de dados MySQL. Substitua <code class="codespan cursor-pointer z-[9] relative">yourpassword</code> pela senha do seu servidor MySQL. </p>
<div class="my-2"></div>
<div>
    <div class="my-2 code-cntainer" dir="ltr">
        <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
        <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
            <div class="flex translate-y-[1px] items-center gap-0.5">
                <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
            </div>
        </div>
        <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
            <div class="code-block-header"></div>
            <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-46" class="code-textarea h-full w-full ">
                <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                    <div class="cm-announced" aria-live="polite"></div>
                    <div tabindex="-1" class="cm-scroller">
                        <div class="cm-gutters" aria-hidden="true" style="min-height: 75.1719px; position: sticky;">
                            <div class="cm-gutter cm-lineNumbers">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                            </div>
                            <div class="cm-gutter cm-foldGutter">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                            </div>
                        </div>
                        <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                            <div class="cm-activeLine cm-line"><span class="ͼ13">"ConnectionStrings"</span><span class="ͼt">:</span> {</div>
                            <div class="cm-line">    <span class="ͼq">"DefaultConnection"</span><span class="ͼt">:</span> <span class="ͼ13">"Server=localhost;Database=WalletDB;User=root;Password=yourpassword;"</span></div>
                            <div class="cm-line">}</div>
                        </div>
                        <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                            <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                        </div>
                        <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-46" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
    </div>
</div>
<div class="my-2"></div>
<h3>4. Instalar as Dependências </h3>
<p>Instale as dependências necessárias para o projeto: </p>
<div class="my-2"></div>
<div>
    <div class="my-2 code-cntainer" dir="ltr">
        <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">bash</div>
        <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
            <div class="flex translate-y-[1px] items-center gap-0.5">
                <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
            </div>
        </div>
        <div class="language-bash  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
            <div class="code-block-header"></div>
            <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-51" class="code-textarea h-full w-full ">
                <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                    <div class="cm-announced" aria-live="polite"></div>
                    <div tabindex="-1" class="cm-scroller">
                        <div class="cm-gutters" aria-hidden="true" style="min-height: 30.3906px; position: sticky;">
                            <div class="cm-gutter cm-lineNumbers">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                            </div>
                            <div class="cm-gutter cm-foldGutter">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"></div>
                            </div>
                        </div>
                        <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="shell" aria-autocomplete="list">
                            <div class="cm-activeLine cm-line">dotnet restore</div>
                        </div>
                        <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                            <div class="cm-cursor cm-cursor-primary" style="left: 37.125px; top: 5px; height: 19px;"></div>
                        </div>
                        <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-51" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
    </div>
</div>
<div class="my-2"></div>
<hr>
<h2>Executando o Projeto </h2>
<h3>1. Executar Migrações (Opcional) </h3>
<p>Se você precisar alterar o esquema do banco de dados no futuro, pode usar o Entity Framework Core para gerar e aplicar migrações: </p>
<div class="my-2"></div>
<div>
    <div class="my-2 code-cntainer" dir="ltr">
        <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">bash</div>
        <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
            <div class="flex translate-y-[1px] items-center gap-0.5">
                <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
            </div>
        </div>
        <div class="language-bash  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
            <div class="code-block-header"></div>
            <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-58" class="code-textarea h-full w-full ">
                <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                    <div class="cm-announced" aria-live="polite"></div>
                    <div tabindex="-1" class="cm-scroller">
                        <div class="cm-gutters" aria-hidden="true" style="min-height: 52.7812px; position: sticky;">
                            <div class="cm-gutter cm-lineNumbers">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                            </div>
                            <div class="cm-gutter cm-foldGutter">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"></div>
                            </div>
                        </div>
                        <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="shell" aria-autocomplete="list">
                            <div class="cm-activeLine cm-line">dotnet ef migrations add InitialCreate</div>
                            <div class="cm-line">dotnet ef database update</div>
                        </div>
                        <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                            <div class="cm-cursor cm-cursor-primary" style="left: 37.125px; top: 5px; height: 19px;"></div>
                        </div>
                        <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-58" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
    </div>
</div>
<div class="my-2"></div>
<h3>2. Iniciar o Projeto </h3>
<p>Execute o projeto com o seguinte comando: </p>
<div class="my-2"></div>
<div>
    <div class="my-2 code-cntainer" dir="ltr">
        <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">bash</div>
        <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
            <div class="flex translate-y-[1px] items-center gap-0.5">
                <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
            </div>
        </div>
        <div class="language-bash  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
            <div class="code-block-header"></div>
            <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-63" class="code-textarea h-full w-full ">
                <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                    <div class="cm-announced" aria-live="polite"></div>
                    <div tabindex="-1" class="cm-scroller">
                        <div class="cm-gutters" aria-hidden="true" style="min-height: 30.3906px; position: sticky;">
                            <div class="cm-gutter cm-lineNumbers">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                            </div>
                            <div class="cm-gutter cm-foldGutter">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"></div>
                            </div>
                        </div>
                        <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="shell" aria-autocomplete="list">
                            <div class="cm-activeLine cm-line">dotnet run</div>
                        </div>
                        <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                            <div class="cm-cursor cm-cursor-primary" style="left: 37.125px; top: 5px; height: 19px;"></div>
                        </div>
                        <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-63" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
    </div>
</div>
<div class="my-2"></div>
<p>A API estará disponível em <code class="codespan cursor-pointer z-[9] relative">http://localhost:5000</code> ou <code class="codespan cursor-pointer z-[9] relative">https://localhost:5001</code>. </p>
<div class="my-2"></div>
<hr>
<h2>Rotas da API </h2>
<p>A API segue os padrões REST e utiliza autenticação JWT para proteger as rotas sensíveis. Abaixo estão as rotas disponíveis: </p>
<div class="my-2"></div>
<h3>Autenticação </h3>
<h4>Registrar Usuário </h4>
<ul>
    <li><strong>POST </strong> <code class="codespan cursor-pointer z-[9] relative">/api/auth/register</code></li>
    <li>
        Corpo da requisição:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-73-1-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 97.5625px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">4</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"username"</span><span class="ͼt">:</span> <span class="ͼ13">"user3"</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">    <span class="ͼq">"password"</span><span class="ͼt">:</span> <span class="ͼ13">"password123"</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-73-1-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
    <li>
        Resposta:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-73-2-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 75.1719px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"message"</span><span class="ͼt">:</span> <span class="ͼ13">"User registered successfully."</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-73-2-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
</ul>
<div class="my-2"></div>
<h4>Logar Usuário </h4>
<ul>
    <li><strong>POST </strong> <code class="codespan cursor-pointer z-[9] relative">/api/auth/login</code></li>
    <li>
        Corpo da requisição:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-76-1-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 97.5625px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">4</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"username"</span><span class="ͼt">:</span> <span class="ͼ13">"user3"</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">    <span class="ͼq">"password"</span><span class="ͼt">:</span> <span class="ͼ13">"password123"</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-76-1-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
    <li>
        Resposta:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-76-2-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 75.1719px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"token"</span><span class="ͼt">:</span> <span class="ͼ13">"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-76-2-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
</ul>
<div class="my-2"></div>
<h3>Carteira </h3>
<h4>Consultar Saldo </h4>
<ul>
    <li><strong>GET </strong> <code class="codespan cursor-pointer z-[9] relative">/api/wallet/balance</code></li>
    <li>Cabeçalho: <code class="codespan cursor-pointer z-[9] relative">Authorization: Bearer &lt;token&gt;</code></li>
    <li>
        Resposta:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-80-2-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 75.1719px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"balance"</span><span class="ͼt">:</span> <span class="ͼu">1000.00</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-80-2-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
</ul>
<div class="my-2"></div>
<h4>Adicionar Saldo </h4>
<ul>
    <li><strong>POST </strong> <code class="codespan cursor-pointer z-[9] relative">/api/wallet/add-balance</code></li>
    <li>Cabeçalho: <code class="codespan cursor-pointer z-[9] relative">Authorization: Bearer &lt;token&gt;</code></li>
    <li>
        Corpo da requisição:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-83-2-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 75.1719px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"amount"</span><span class="ͼt">:</span> <span class="ͼu">500.00</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-83-2-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
    <li>
        Resposta:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-83-3-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 97.5625px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">4</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"message"</span><span class="ͼt">:</span> <span class="ͼ13">"Balance updated successfully."</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">    <span class="ͼq">"newBalance"</span><span class="ͼt">:</span> <span class="ͼu">1500.00</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-83-3-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
</ul>
<div class="my-2"></div>
<h3>Transações </h3>
<h4>Realizar Transferência </h4>
<ul>
    <li><strong>POST </strong> <code class="codespan cursor-pointer z-[9] relative">/api/transaction/transfer</code></li>
    <li>Cabeçalho: <code class="codespan cursor-pointer z-[9] relative">Authorization: Bearer &lt;token&gt;</code></li>
    <li>
        Corpo da requisição:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-87-2-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 97.5625px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">4</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"receiverId"</span><span class="ͼt">:</span> <span class="ͼu">2</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">    <span class="ͼq">"amount"</span><span class="ͼt">:</span> <span class="ͼu">200.00</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-87-2-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
    <li>
        Resposta:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-87-3-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 97.5625px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">4</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">{</span></div>
                                    <div class="cm-line">    <span class="ͼq">"message"</span><span class="ͼt">:</span> <span class="ͼ13">"Transfer successful."</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">    <span class="ͼq">"newBalance"</span><span class="ͼt">:</span> <span class="ͼu">800.00</span></div>
                                    <div class="cm-line"><span class="cm-matchingBracket">}</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 37.3281px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-87-3-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
</ul>
<div class="my-2"></div>
<h4>Listar Histórico de Transações </h4>
<ul>
    <li><strong>GET </strong> <code class="codespan cursor-pointer z-[9] relative">/api/transaction/history?startDate=2023-01-01&amp;endDate=2023-12-31</code></li>
    <li>Cabeçalho: <code class="codespan cursor-pointer z-[9] relative">Authorization: Bearer &lt;token&gt;</code></li>
    <li>
        Parâmetros opcionais:
        <ul>
            <li><code class="codespan cursor-pointer z-[9] relative">startDate</code>: Data inicial (formato: <code class="codespan cursor-pointer z-[9] relative">yyyy-MM-dd</code>).</li>
            <li><code class="codespan cursor-pointer z-[9] relative">endDate</code>: Data final (formato: <code class="codespan cursor-pointer z-[9] relative">yyyy-MM-dd</code>).</li>
        </ul>
    </li>
    <li>
        Resposta:
        <div>
            <div class="my-2 code-cntainer" dir="ltr">
                <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">json</div>
                <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
                    <div class="flex translate-y-[1px] items-center gap-0.5">
                        <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                        <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                    </div>
                </div>
                <div class="language-json  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
                    <div class="code-block-header"></div>
                    <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-90-3-1" class="code-textarea h-full w-full ">
                        <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                            <div class="cm-announced" aria-live="polite"></div>
                            <div tabindex="-1" class="cm-scroller">
                                <div class="cm-gutters" aria-hidden="true" style="min-height: 366.25px; position: sticky;">
                                    <div class="cm-gutter cm-lineNumbers">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">99</div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">3</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">4</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">5</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">6</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">7</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">8</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">9</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">10</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">11</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">12</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">13</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">14</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">15</div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;">16</div>
                                    </div>
                                    <div class="cm-gutter cm-foldGutter">
                                        <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                        <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"><span title="Fold line">⌄</span></div>
                                        <div class="cm-gutterElement" style="height: 22.3906px;"><span title="Fold line">⌄</span></div>
                                        <div class="cm-gutterElement" style="height: 22.3906px; margin-top: 134.344px;"><span title="Fold line">⌄</span></div>
                                    </div>
                                </div>
                                <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="json">
                                    <div class="cm-activeLine cm-line"><span class="cm-matchingBracket">[</span></div>
                                    <div class="cm-line">    {</div>
                                    <div class="cm-line">        <span class="ͼq">"id"</span><span class="ͼt">:</span> <span class="ͼu">1</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"senderId"</span><span class="ͼt">:</span> <span class="ͼu">1</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"receiverId"</span><span class="ͼt">:</span> <span class="ͼu">2</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"amount"</span><span class="ͼt">:</span> <span class="ͼu">200.00</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"timestamp"</span><span class="ͼt">:</span> <span class="ͼ13">"2023-10-01T12:34:56Z"</span></div>
                                    <div class="cm-line">    }<span class="ͼt">,</span></div>
                                    <div class="cm-line">    {</div>
                                    <div class="cm-line">        <span class="ͼq">"id"</span><span class="ͼt">:</span> <span class="ͼu">2</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"senderId"</span><span class="ͼt">:</span> <span class="ͼu">2</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"receiverId"</span><span class="ͼt">:</span> <span class="ͼu">1</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"amount"</span><span class="ͼt">:</span> <span class="ͼu">100.00</span><span class="ͼt">,</span></div>
                                    <div class="cm-line">        <span class="ͼq">"timestamp"</span><span class="ͼt">:</span> <span class="ͼ13">"2023-10-02T14:20:10Z"</span></div>
                                    <div class="cm-line">    }</div>
                                    <div class="cm-line"><span class="cm-matchingBracket">]</span></div>
                                </div>
                                <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                                    <div class="cm-cursor cm-cursor-primary" style="left: 43.5625px; top: 5px; height: 19px;"></div>
                                </div>
                                <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                            </div>
                        </div>
                    </div>
                </div>
                <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-90-3-1" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
            </div>
        </div>
    </li>
</ul>
<div class="my-2"></div>
<hr>
<h2>Scripts e Comandos Úteis </h2>
<h3>Criar Nova Migração </h3>
<p>Se você alterar os modelos, crie uma nova migração: </p>
<div class="my-2"></div>
<div>
    <div class="my-2 code-cntainer" dir="ltr">
        <div class="text-text-300 absolute py-1.5 pl-4 text-xs font-medium dark:text-white">bash</div>
        <div class="copy top-8 z-10 mb-1 flex items-center justify-end py-1 pr-2.5 text-xs text-black dark:text-white">
            <div class="flex translate-y-[1px] items-center gap-0.5">
                <div aria-label="Copiar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Copy !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
                <div aria-label="Descarregar" class="flex" style=""><button class="copy-code-button rounded-md border-none bg-gray-50 bg-none px-1.5 py-0.5 transition"><i class="iconfont leading-none icon-Download !text-[0.75rem] text-[#2C2C36] dark:text-[#FAFAFC]" style=""></i></button></div>
            </div>
        </div>
        <div class="language-bash  -mt-8 rounded-t-xl rounded-b-xl overflow-hidden ">
            <div class="code-block-header"></div>
            <div id="code-textarea-281c3aa5-ee63-4766-912f-03dd3ffd4185-97" class="code-textarea h-full w-full ">
                <div class="cm-editor ͼ1 ͼ3 ͼ4 ͼo">
                    <div class="cm-announced" aria-live="polite"></div>
                    <div tabindex="-1" class="cm-scroller">
                        <div class="cm-gutters" aria-hidden="true" style="min-height: 52.7812px; position: sticky;">
                            <div class="cm-gutter cm-lineNumbers">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;">9</div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;">1</div>
                                <div class="cm-gutterElement" style="height: 22.3906px;">2</div>
                            </div>
                            <div class="cm-gutter cm-foldGutter">
                                <div class="cm-gutterElement" style="height: 0px; visibility: hidden; pointer-events: none;"><span title="Unfold line">›</span></div>
                                <div class="cm-gutterElement cm-activeLineGutter" style="height: 22.3906px; margin-top: 4px;"></div>
                            </div>
                        </div>
                        <div spellcheck="false" autocorrect="off" autocapitalize="off" writingsuggestions="false" translate="no" contenteditable="false" style="tab-size: 4;" class="cm-content" role="textbox" aria-multiline="true" aria-placeholder="Enter your code here..." data-language="shell" aria-autocomplete="list">
                            <div class="cm-activeLine cm-line">dotnet ef migrations add MigrationName</div>
                            <div class="cm-line">dotnet ef database update</div>
                        </div>
                        <div class="cm-layer cm-layer-above cm-cursorLayer" aria-hidden="true" style="z-index: 150; animation-duration: 1200ms;">
                            <div class="cm-cursor cm-cursor-primary" style="left: 37.125px; top: 5px; height: 19px;"></div>
                        </div>
                        <div class="cm-layer cm-selectionLayer" aria-hidden="true" style="z-index: -2;"></div>
                    </div>
                </div>
            </div>
        </div>
        <div id="plt-canvas-281c3aa5-ee63-4766-912f-03dd3ffd4185-97" class="scrollbar-hidden max-w-full overflow-x-auto bg-[#202123] text-white"></div>
    </div>
</div>
<div class="my-2"></div>
<h3>Popular o Banco de Dados </h3>
<p>Use o script <code class="codespan cursor-pointer z-[9] relative">database.sql</code> para popular o banco de dados com dados fictícios. </p>
<div class="my-2"></div>
<h3>Testar a API </h3>
<p>Use ferramentas como Postman ou Insomnia para testar as rotas da API. </p>
<div class="my-2"></div>
<hr>
<h2>Considerações Finais </h2>
<p>Este projeto é uma implementação básica de uma API para gerenciar carteiras digitais e transações financeiras. Ele pode ser expandido com funcionalidades adicionais, como notificações, relatórios detalhados, integração com serviços de pagamento e muito mais. </p>
<div class="my-2"></div>
<p>Se você tiver dúvidas ou sugestões, fique à vontade para abrir uma issue ou enviar um pull request! </p>
<div class="my-2"></div>
<hr>
<h3>Licença </h3>
<p>Este projeto está licenciado sob a <a href="LICENSE" target="_blank" rel="nofollow" style="position: relative;">MIT License </a>. </p>
<div class="my-2"></div>
<hr>