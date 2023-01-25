# Codificação com Hashids 

Hashids é um pacote .NET e funciona como uma codificação reversível. Ele codifica um número ou uma matriz de números em uma cadeia de caracteres exclusiva, semelhante aos Ids do Youtube. Diferente de uma codificação clássica de hash, o hashids permite decodificação, então é possível reverter o ID ao número original. <br>

<a href = "https://www.nuget.org/packages/Hashids.net">Instalação do pacote</a>

## Hashids para números negativos

Não é possível usá-lo diretamente para codificar um número negativo, mas é possível contornar o problema com alguns passos.

### <a href = "https://github.com/s-s-silva/HashidsNegative/blob/master/Program.cs" >Implementação</a>
