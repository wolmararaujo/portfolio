# Git

**Git** é um sistema de controle de versões distribuído, ou seja, um software que rastreia os arquivos e controla o que você tem na sua máquina com o que existe no repositório.

**Github, Gitlab, Bitbucket** são serviços baseados em nuvem que hospedam um sistema de controle de versão chamado Git. É de fato onde está o repositório compartilhado entre todas as pessoas de um projeto. 

**Vantagens do uso**

**Histórico**

Alternar entre versões (log)

​    Tranquilidade de saber que tem um backup, um plano B

**Trabalho em Equipe**

​    Várias pessoas trabalhando em paralelo no mesmo projeto

**Ramificação**

​    Permite que você criar várias versões a partir de um ponto (branches)

​    Junção das funcionalidades após finalizadas (merges)

**Rastreabilidade**

​    Identificar em que ponto a mudança foi feita

​    Identificar o responsável pela mudança

**Instalação do Git**

Para **windows** só fazer o download e instalar com next next next.

<https://git-scm.com/download/win>

Para **linux**

**sudo apt install git**

<https://git-scm.com/download/linux>

No **mac** fazer o download do pkg e instalar, em alguns casos é necessário liberar no sistema de segurança do mac a instalação de fontes desconhecidas.

<https://git-scm.com/download/mac>

Recomendo fortemente que saiba usar o Git no terminal e evite uso do Git Desktop.

Para ter certeza que o git foi instalado faça o comando no terminal

**git --version**

**Recomendo primeiro ler o documento até o final para depois iniciar os comandos de teste e prática. Entenda o conceito e depois aplique.**

**Arquitetura do um sistema Git**

![img](https://whimuc.com/MmtwAjsVtWRtkkVH5JEQV5/3mE955iMpHBsT2.png)

Toda vez que temos uma pasta/ projeto  dentro teremos um arquivo oculto de controle do git chamado **.git.** Uma pasta que não tem esse arquivo não está sendo controlada pelo git. Para isso é necessário o comando dentro da pasta.

**git init**

É necessário configurar algumas variáveis que o git usa para rastrear o usuário que fez as mudanças no arquivo e commitou, lembrando que as variáveis para o git são case sensitive. Por padrão é bom usar no nome a primeira letra maiúscula.

**Config**

É necessário configurar algumas variáveis que o git usa para rastrear o usuário que fez as mudanças no arquivo e comitou, lembrando que as variáveis para o git são case sensitive. Por padrão é bom usar no nome a primeira letra maiúscula. Esses comandos são usados praticamente só para configurar variáveis e personalizar algumas coisas necessárias.

**git config --global user.name “Fulano Tall”**

**git config --global use.email “fulanotal@gmail.com”**

**git config --list**

Algumas outras configurações podem ser legais, mas não necessárias, acostume-se a manter o padrão.

**git config --global core.editor code**

**git config --global color.branch auto**

**git config --global color.diff auto**

**git config --global color.interactive auto**

**git config --global color.status auto**

**EXTRA**

**--system**    são configurações em nível de sistema, todos os usuários terão a mesma configuração (evite)

**--global**     são configurações a nível de usuário

**--local** são configurações a nível de projeto/repositório/pasta

Para mais informações <https://git-scm.com/docs/git-config>

**ARQUIVOS QUE NÃO QUERO VERSIONAR**

Quando você não quer versionar um arquivo, por exemplo um arquivo de senhas ou até mesmo arquivos de compilação local, você pode ignorá-los.Basta criar um arquivo oculto na pasta do projeto chamado **.gitignore** e dentro desse arquivo coloque todos os arquivos ou tipos que você quer ignorar.

exemplo de gitignore:

*.bmp     (exclui todos os arquivos dessa extensão)

bla/*.bmp     (exclui todos os arquivos dessa extensão na pasta bla)

Alguns exemplos de gitignore para projetos <https://github.com/github/gitignore>

**Clone**

Útil para clonar um repositório no em algum servidor github gitlab ou outros.

**git clone urldorepositorio.git**

É possível também clonar um repositório local passando a pasta ao invés da url

**git clone pasta/x pasta2/y** (vai clonar o caminho o projeto x para o projeto y)

para mais informações <https://git-scm.com/docs/git-clone>

**Add, Status, Commit, ls e Diff**

Para rastrear os arquivos e passar eles para stage é utilizados os possíveis comandos abaixo.

**git add nomedoarquivo **ou **git add nomearquivo1 nomearquivo2**

**git add -A **ou **git add --all** (adiciona todos os arquivos)

**git add .** (adiciona todos os arquivos a partir do diretório que vc está)

**git ls-files -s** ou **--stage** mostra a lista de stage

**git ls-files -m** ou **--modified** mostra de modificados

**git ls-files -o** ou **-- others** mostra a lista de não trackeados

para mais informações <https://git-scm.com/docs/git-ls-files>

**git status** (para ver o status de como está no momento o git)

**git status -bs** para uma saída menor e a branch que está.

para mais informações <https://git-scm.com/docs/git-status>

Para fazer um commit, ou seja criar um ponto de versionando para o arquivo.

**git commit -m “mensagem”** (todos os arquivos)

**git commit -m “mensagem” \** (todos os arquivos)

**git commit -m “mensagem” arquivo** (arquivo específico)

**git commit -m “mensagem” arquivo1 arquivo2** (múltiplos arquivos específicos)

Em alguns casos você precisa mudar algo quando tudo já foi comitado e para não gerar mais um commit você precisa acrescentar algo.

**git commit --amend** (vai acrescentar as mudanças)

Para mais informações <https://git-scm.com/docs/git-commit>

Entendendo novamente o sistema de estados de um arquivo antes dele ir para um repositório em algum servidor.

![img](https://whimuc.com/MmtwAjsVtWRtkkVH5JEQV5/CAeX7ZzHydJ7J8.png)

Um commit sobe o que está na Stage para o Head. 

Para ver as diferenças é bom usar o comando diff.

**git diff** (mostra a diferença do que tem no repositório de trabalho com o último .commit )

**git diff --cached** ou **git diff --staged** (mostra a diferença do que tem no último commit com o que tem na área de staged)

Um atalho rápido para adicionar e comitar ao mesmo tempo, mas só funcionar com arquivos que já são conhecidos pelo git

**git commit -a -m “mensagem”** (add todos os arquivos rastreados e já comita)

**Log**

Para ver o histórico de commits, usamos o log. Quando o seu projeto está atualizando com o do repositório ele trás o log de todos em todas as branches.

**git log (vai aparecer todos os commits)**

**git log -3** (vai aparecer os últimos 3 commits)

**git log --oneline** (vai mostrar resumido)

**git log --author=”Fulano Tal”**  (vai mostrar somente os commits dessa pessoa por isso é importante fazer o git config do usuário e email)

**git log --graph --decorate** (mostra o log de forma mais bonita com uma linhas mostrando as branches)

**git log origin/nomedabranch --oneline** (mostra os commits da branch)

Obs: O hash do commit é o que você precisa para reverter um commit. No comando

log ele mostra onde está o seu Head e os hashes dos comites.

Para mais informações <https://git-scm.com/docs/git-log>

**Checkout**

Usado para ira para um ponto específico de um projeto, seja commit, branches e tags. Para voltar em algum ponto de commit é usado checkout e o hash do commit. O checkout também é usado para mudar de branch como veremos posteriormente.

**git checkout meuhash** (pode ser colocado só os 5 ou 6 primeiros caracteres do hash)

**git checkout nomedabranch** (volta para o topo daquela branch)

Se você estiver mudando de branch e os arquivos daquela branch não estiverem comitados, em tese eles seriam perdidos e o git não deixa você fazer isso. Ou você comita para salvar ou dá um reset --hard como mostrado abaixo.

**git checkout nomedoarquivo** (volta aquele arquivo específico do último commit da branch que você está)

Para mais informações <https://git-scm.com/docs/git-checkout>

**Reset X Clean**

**git reset --hard** (é como se você desse um checkout em todos os arquivos e de fato volta o estado inicial daquele ponto de partida, ou commit)

**git reset --hard HEAD~n** (desfazer os commits sendo n o número de commits que você quer desfazer)

NÃO É POSSÍVEL DESFAZER UM COMMIT NO REPOSITÓRIO REMOTO, TEM QUE FAZER UM COMMIT POR CIMA DE CORREÇÃO.

Um detalhe interessante é que se você criar um arquivo na working dir e ele nunca tiver ido para a área de Staged, ou seja, o git nunca rastreou este arquivo, mesmo que você volte commit ou até de um checkout para o Head daquela branch ele continuará no projeto.

Para deletar de fato um arquivo não rastreado faça

**git clean -f**

**Branch**

Usado para manipular as ramificações localmente.

**Entendendo como funciona uma branch**

A branch é uma ramificação para que o projeto siga por N caminhos a partir de um ponto. Se você tem uma versão estável, ou seja, a branch main, você pode desenvolver várias versões do projeto sem impactar na sua versão estável. A branch é uma ramificação a nível de projeto, não confundir com um fork.

![img](https://whimuc.com/MmtwAjsVtWRtkkVH5JEQV5/5yPxpDEEemvTTu.png)

Uma boa prática que esta sendo implantada nas maiores empresas é deixar de chamar a branch principal de master e chamar de main. Master é considerado usuário e em programação o principal chama main.

Comandos usando branches.

**git branch** (lista as branches locais)

**git branch novabranch** (cria uma nova branch local)

**git branch -d nomedabranch** (Para remover uma branch local. Só funciona se você não estiver com checkout nela)

**git branch -D nomedabranch** (Para forçar a remoção da branch local, mas ainda sim é preciso apontado para outra branch)

**git checkout novabranch** (passa para a branch com esse nome)

um corta caminho é fazer 

**git checkout -b novabranch** (já passa pra branch criando ela localmente)

**git branch -m novonome** (se você estiver na branch)

**git branch -m nomedabranch novonome** (se você estiver em outra  branch)

Para mais informações <https://git-scm.com/docs/git-branch>

**Push**

Usado para dar comando direto no repositório. Tudo que vai para o repositório leva essa palavra. O comando push sobe os arquivos locais da branch que você está para a respectiva branch no servidor Github, Gitblab, Bitbucket, etc.

**git push** (vai tentar subir a branch para a principal, master/main. Nesse caso, se você estiver em uma branch diferente vai dar erro. Não é uma boa prática fazer esse comando sem apontar a branch que você deseja para evitar publicar na master/main)

**git push origin minhabranch** (Se não existir a branch ele vai criar)

**git push -u origin minhabranch** (MESMA COISA)

**git push --set-upstream origin minhabranch** (MESMA COISA)

**git push --delete origin nomedabranch** (deleta a branch do servidor) 

obs: Se for apagar uma branch no servidor deve ser alinhado com toda a equipe antes para evitar que outras pessoas que estão usando essa branch não a encontre depois e gere problemas

Curiosidade: o git não faz o push de um diretório vazio sem nenhum arquivo.

**Fetch**

É quando você solicita para o servidor que traga as modificações do repositório para a máquina local, mas não aplica. 

**git fetch**

usado para observar como está o projeto a frente sem sair do ponto que você está.

**Merge**

O merge é quando você mescla/junta as alterações de uma branch com outra.

Vá para a branch que receberá as alterações e o comando de merge puxando daquela que você deseja mergear.

**git merge** (vai fazer o merge com a branch de mesmo nome que você, caso exista)

**git merge nomedabranch** (Se você estiver na master por exemplo ele irá trazer as alterações da developer para a master)

O git merge faz as alterações e já faz um commit caso não tenha conflitos, pois ele cria um ponto de restauração.

![img](https://whimuc.com/MmtwAjsVtWRtkkVH5JEQV5/F6isTfyvfwx7bj.png)

**Pull**

O comando pull é a soma do comando fetch com o comando merge. Ele puxa as alterações do servidor já faz o merge localmente.

**git pull** (atualiza todo o conteúdo do servidor com o da sua máquina, para a branch que vc esta)

Uma curiosidade, se você der um git pull e existir algum branch diferente das suas locais ela não aparece no comando git branch na listagem apesar de existir. Ela só aparece se você der um checkout para ela manualmente.

Se você criou uma branch local e ela não existe no servidor e você tentar dar um git pull, acontecerá um erro até que você crie a mesma branch igual no servidor.

**Remote**

Usado para conferir os dados do repositório associado ao projeto na máquina local

**git remote -v**  (mostra a url do push e do fetch)

**git remote add origin urlDoRepositorio.git ()**

**git pull** (atualiza todo o conteúdo do servidor com o da sua máquina, incluindo branches de outros usuários que subiram)

Uma curiosidade, se você der um git pull e existir algum branch diferente das suas locais ela não aparece no comando git branch na listagem apesar de existir. Ela só aparece se você der um checkout para ela manualmente.

Se você criou uma branch local e ela não existe no servidor e você tentar dar um git pull, acontecerá um erro até que você crie a mesma branch igual no servidor.

**Tags**

Imagine uma tag como sendo um snapshot do projeto naquele momento. Diferente das branches eles são imutáveis. Se você der um checkout em uma tag e fazer commits nada mudará a não ser que crie uma branch primeiro a partir daquele ponto e inicie uma nova ramificação. Nos repositórios elas são as releases do projeto.

**git tag** (lista as tags)

**git tag -a nomedatag -m “mensagem para explicar essa tag”** (criando uma tag localmente do seu checkout do momento)

**git tag -a nomedatag hashDoComite -m “mensagem de explicação”** (criando uma tag localmente a partir de um commit sem sair do seu checkout)

**git push origin nomedatag** (enviando a tag paga o repositório remoto)

**git tag -d nomedatag** (remove a tag localmente)

**git push --delete origin nomedatag** (remove a tag do repositório)

Para saber mais <https://git-scm.com/docs/git-tag>

**Remote**

Quando você abre um projeto local e dá um git init nesse projeto para o git começar a versionar isso localmente você não conseguirá dar um git push se ele não souber qual é o endereço do repositório com o qual ele está vinculado. O remote serve para vincular um projeto local a um repositório em um servidor remoto.

git remote add meurepositório.git

**(COMANDO AVANÇADO)**

**Stash**

Se você fez alguma modificação, mas ainda não está pronto para commitar pois ainda existe algum tipo de erro ou ainda não finalizou o que você está fazendo, ou até mesmo precisa trocar de branch para ajudar um amigo, para mudar de branch ou é preciso commitar ou reverter. Se comitar com erro não é boa prática, se reverter vai perder todo o trabalho. o Stash salva em memória o que você está fazendo para deixar para que possa mudar de branch. Funciona como uma pilha.

**git stash save “Mensagem de lembrete”** (salva a mudança)

**git stash** (é a mesma coisa, mas ele faz uma mensagem automática)

**git stash list** (mostra a lista de stashes)

**git stash apply** (traz o topo da pilha, mas não deleta da pilha)

**git stash apply stash@{n}** (vai para o stash específico mas não deleta)

**git stash pop** (vai para o último do topo da pilha, ou seja o mais recente)

**git stash pop stash@{n}** (passa já deletando)

**git stash drop stash@{n}** (remove exatamente qual stash vc quer remover)

<https://git-scm.com/docs/git-stash>

**O que é um Fork?**

Quando você faz um clone de um projeto que não é seu, mas o projeto é público, você não consegue versionar para o repositório daquela pessoa, pois você não tem permissão para isso. Dessa forma, você pode criar um fork daquele projeto iniciando uma cópia do mesmo para o seu repositório onde você consegue fazer as modificações que você deseja ou até usar como base para mudar o caminho do projeto. Dessa forma, irá clonar um projeto idêntico no seu repositório e terá todas as permissões para fazer o push. O GitHub, GitLab e outros, guardam qual foi o repositório pai daquele fork, dessa forma você poderia gerar um pull request para colaborar com o projeto pai. Caso você faça uma fork para resolver uma Issue vc consegue apontar ela utilizando Close #numeroDaIssue para linkar o pull requesta a uma issue.

**O que é um Pull Request?**

O pull request é quando você pede para contribuir com o projeto pai de um fork. O dono daquele projeto irá avaliar suas modificações e se quiser e achar que vale a pena, fará um merge com suas modificações para somá-las ao código dele. É dessa maneira que um projeto é mantido pela comunidade.

**O que é uma Issue?**

É uma forma de relatar um bug/erro, uma possível melhoria em algo, uma possível funcionalidade, ou seja, é uma forma de ajudar dando suas sugestões até mesmo como utilizador do projeto em questão para o mantenedor melhorar ainda mais o seu projeto. Afinal, duas cabeças pensam melhor do que uma.

Dentro do conceito de Issues existem os labels

​    **Labels ** são as tags que o mantenedor do projeto dá para cada uma das issues, são etiquetas na verdade para reportar que tipo de Issue é aquela. Ex: Bug, Erro de Lógica, Melhoria, Questão, Issue duplicada, etc.

​    **Milestones** é como se fosse um conceito de release. Vamos imaginar que alguém faça uma proposta de melhoria que já estava preparada para entrar na versão 2.0 do projeto, mas não será resolvido agora. Você pode programar aquelas Issues para serem resolvidas por releases e quem estiver acompanhando o seu projeto saberá quando será implementada caso for. 

obs: Existem casos que o mantenedor coloca labels com o número da versão para que você filtre as issues pela versão. 

Hoje acredito que o melhor software gráfico para o git que suporta todos os sistemas operacionais é o GitKraken

https://www.gitkraken.com

https://www.gitkraken.com/download

**AUTENTICAÇÃO SSH.**

**TODA VEZ QUE VOCÊ TEM UM SERVIDOR REMOTO VOCÊ PRECISA SE AUTENTICAR NELE. SE VOCÊ COLOCAR SUA CHAVE PÚBLICA NO SERVIDOR VOCÊ NÃO PRECISA FICAR FAZENDO SUA AUTENTICAÇÃO.**

https://dillinger.io/
