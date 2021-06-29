DECLARE @var0 nvarchar(128)
SELECT @var0 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Enderecos')
AND col_name(parent_object_id, parent_column_id) = 'Logradouro';
IF @var0 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [' + @var0 + ']')
ALTER TABLE [dbo].[Enderecos] ALTER COLUMN [Logradouro] [varchar](100) NOT NULL
DECLARE @var1 nvarchar(128)
SELECT @var1 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Enderecos')
AND col_name(parent_object_id, parent_column_id) = 'Numero';
IF @var1 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [' + @var1 + ']')
ALTER TABLE [dbo].[Enderecos] ALTER COLUMN [Numero] [varchar](100) NOT NULL
DECLARE @var2 nvarchar(128)
SELECT @var2 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Enderecos')
AND col_name(parent_object_id, parent_column_id) = 'Complemento';
IF @var2 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [' + @var2 + ']')
ALTER TABLE [dbo].[Enderecos] ALTER COLUMN [Complemento] [varchar](100) NOT NULL
DECLARE @var3 nvarchar(128)
SELECT @var3 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Enderecos')
AND col_name(parent_object_id, parent_column_id) = 'Bairro';
IF @var3 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [' + @var3 + ']')
ALTER TABLE [dbo].[Enderecos] ALTER COLUMN [Bairro] [varchar](100) NOT NULL
DECLARE @var4 nvarchar(128)
SELECT @var4 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Enderecos')
AND col_name(parent_object_id, parent_column_id) = 'Cidade';
IF @var4 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [' + @var4 + ']')
ALTER TABLE [dbo].[Enderecos] ALTER COLUMN [Cidade] [varchar](100) NOT NULL
DECLARE @var5 nvarchar(128)
SELECT @var5 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Enderecos')
AND col_name(parent_object_id, parent_column_id) = 'Cep';
IF @var5 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [' + @var5 + ']')
ALTER TABLE [dbo].[Enderecos] ALTER COLUMN [Cep] [varchar](8) NOT NULL
DECLARE @var6 nvarchar(128)
SELECT @var6 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Enderecos')
AND col_name(parent_object_id, parent_column_id) = 'Estado';
IF @var6 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [' + @var6 + ']')
ALTER TABLE [dbo].[Enderecos] ALTER COLUMN [Estado] [varchar](30) NOT NULL
DECLARE @var7 nvarchar(128)
SELECT @var7 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Fornecedores')
AND col_name(parent_object_id, parent_column_id) = 'Nome';
IF @var7 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Fornecedores] DROP CONSTRAINT [' + @var7 + ']')
ALTER TABLE [dbo].[Fornecedores] ALTER COLUMN [Nome] [varchar](100) NOT NULL
DECLARE @var8 nvarchar(128)
SELECT @var8 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Fornecedores')
AND col_name(parent_object_id, parent_column_id) = 'Documento';
IF @var8 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Fornecedores] DROP CONSTRAINT [' + @var8 + ']')
ALTER TABLE [dbo].[Fornecedores] ALTER COLUMN [Documento] [varchar](100) NOT NULL
DECLARE @var9 nvarchar(128)
SELECT @var9 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Produtos')
AND col_name(parent_object_id, parent_column_id) = 'Nome';
IF @var9 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [' + @var9 + ']')
ALTER TABLE [dbo].[Produtos] ALTER COLUMN [Nome] [varchar](100) NOT NULL
DECLARE @var10 nvarchar(128)
SELECT @var10 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Produtos')
AND col_name(parent_object_id, parent_column_id) = 'Descricao';
IF @var10 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [' + @var10 + ']')
ALTER TABLE [dbo].[Produtos] ALTER COLUMN [Descricao] [varchar](100) NOT NULL
DECLARE @var11 nvarchar(128)
SELECT @var11 = name
FROM sys.default_constraints
WHERE parent_object_id = object_id(N'dbo.Produtos')
AND col_name(parent_object_id, parent_column_id) = 'Imagem';
IF @var11 IS NOT NULL
    EXECUTE('ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [' + @var11 + ']')
ALTER TABLE [dbo].[Produtos] ALTER COLUMN [Imagem] [varchar](100) NOT NULL
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202106291040571_AutomaticMigration', N'Infra.Migrations.Configuration',  0x1F8B0800000000000400ED5BDB6EE336107D2FD07F10F458642D2779D906F62E12275EB8DD5C10278BBE05B43476884AA456A482188B7E591FFA49FD858EAC1BA99B655B89B3E8628185C5CB21399C391CCE30FFFEFDCFE0E3B3E71A4F1008CAD9D03CECF54D0398CD1DCA16433394F377EFCD8F1F7EFE6970E178CFC697B4DD71D40E7B3231341FA5F44F2C4BD88FE011D1F3A81D70C1E7B26773CF220EB78EFAFD5FADC3430B10C2442CC318DC864C520F561FF839E2CC065F86C4BDE40EB82229C79AE90AD5B8221E089FD83034276C1E90DE3991F8DFECD4F75D6A13899312A671EA5282139A823B370DC21897AB9A937B01531970B698FA5840DCBBA50FD86E4E5C01C9324EF2E66D57D43F8A5664E51D53283B14927B1B021E1E2722B28ADDB712B4998910857881C296CB68D52B410ECD0BE6400036378DE260272337881A0ECDB350500642F4E22DE98D79C0C0068707207A29C08191363BC894037528FA77608C425786010C19843220EE817113CE70B77E87E51DFF13D89085AEABCE13678A755A0116DD04DC87402E6F619ECC7EE29886A5F7B38A1DB36E4A9F785D9F428ABFAF706C327321D302ABB1FB67BE0850C261C0531854283411D3B824CF9F812DE4231A4F1F8D624C9FC1494B12EC7B46D1A2B0930C42D878ECABD0837D8C3BE29EEF82074CEE61F0334283BD2C9A3AC4813D8C0B7EC3A0EF5F62C80B2151A51B463DEE66A557E4892E56E4529840CE28A6710B6ECCE28FD48F195C219C879CAFC601F76EB9ABF5CEAA1FEE48B000894BE2F56DA668C5766196032BA7C846E254A7BC2575E61FFF17F2BCE2DE1E2CEA9CDBE19EC8EB54D2A76CD8338EAA48D8C62077D4E7AABA258B882CA358B5B505E676D58DFDA5B6D5647FA98DB69D237E3AA1E4A2728E49E5832A8D7C8AE5DA12435434D9892012BC4DD8215D60FAE3072DBC282D80B003BC32EC8116261E5980F7FAE3DEC4A61B0F7B0E36F5886B1A51294D6E7DE85F4C6D12011E6D8C9E5BCE8EFA105DE946C42142E68E1F96C11DF55E8B82B7755536A6A122513630553B1A0A3D85848AE7C3448C5DB2C86FBC5B7A2E3AECEE34856A8D6782BB443388479F30797C5460AF4BF06610A49A8CA3713246B5B589697C216E888587A56DACE8F35B185047ED7554966C2C43B5F014BBDA7425A39222E487A23E38161B2D4EC8FC345777EA12E546A390066E72D5CA9AC1B3C32D07CF4FEE75D07816604B16C54746A8DCB86D94C9F2C141994D7DE2AE5F62A16BCB5327DA896C9062CD39F880A330B95E06DB8F9E0D52380DD7C9676029DAD2AC44157451B7CD4DDC91EF72E675E89BFC4B83FE34F946DBE9E6560A543F8D57D09F7AE1B6195C3FF85E419162EEC73E127B64FCA605412BB8FD5E4042EF22F11F8A2A11A14E4116EE04E870E7874D894D4A7AA583A8E746058EAA566B9072F7BF8492697D0142115FD58C94DB8CD2B2E1D253DCD9760C9F2DA4288D92A6B42375054FD9A2A2CFAEAFBD855CAA5C97B258D631565BCE5216916F6C83401A58AAA57C1B44927A539945E569072BCE3BA4F909AB264131B824BE8FEE8B92B0484A8C699CAD18BD9B6E1EBFF7620CCB161561FC6CB6D948920778B128D446F15B07C634103272AC672472FC468E576AA6F3478D31A6631529A2BC73A98DA63DA2DF0959D7256E7A7596968B738C2B8C8239ABC542852994BBAE9247C42541C5AD75C4DDD063F567487D6F3511A0A2A8E5EDD1D2D0BE8A9496B547D102F52A9456D11E2F8DBDAB5069D906B34A22E9DA8492B20D50A2B8B8061115B4EF9F06B95588B4AC8C32B00AFA563AD44B0A5E209BA2C5B4B2278DBFBA31A97AA26E61544D9D5FC6ACE258906606AB92F6084AB85785518ADB6325C1031527296A8F51BC83AB60C5BA37A388D999DC8D12A60EDAE61A58DBF3CDAA5F1E56D4D42F2F6E8F95C609B5F52465ED5192A89F0A7253E5BB3761E8571C15AAF9F2D320272DC8A7894AAB7919637D51B32AB993C526D9E8995B59701F07892BB7FE114CC9B78B9B44515DFE449DC8AF9B2E85042FB6CBE95777E4525C6FDEE092303A0721E3789C79D43F3C2A3CA0793B8F592C211C77EB172D13AC7A1E9ADF8CBF5E3F311232FA35041A4501E89C4255D6389B5ED4F7C498FCF130710E8CEB00D77362F471D2BBBF55792281FD488272AE61A797285DA156BC33E90A5A7F45D2D984B537229DA1E62F40AA20DFEFF8BEA30AF378DD2CBB7917F1B60C70872C65575B5D7A9A90019765E73C64AD23570B25799AD71ADF8C89B85F2DF1C4B80B4288E862C7C96999B319951D3D5CA06C1D520739F61F9AB62EDBDD15B09ECBEE0A55CB543BAF91A9DEEA805681763AAAAB52DE0E9120774E79AF37DC3A73EB2AE7D9418E3377EA5A6434FBBD5EE749CDD7484235043FBFCF9465A72A9071FD36D9CEEF60F7EB43246F36E158CE2BB44B2836E613E3FB2BB2DF2CDAEB98B4EAD35CF5E9C635C9C6AA611AB34735E9C8A66C64D51875C9AEBDE42A6B72678D89B8E226EAC997379986DC6DC1858DD6A2922F92622CC77ED072953F9342EA10749143447F34850BD16C366B3361739E12486146699382F77009785B44833E0DD01122B6C46A1B84583D514C9E4C5D78337026EC3A947E2871C9E0CDDCA52A8C88829AC65FE551F5390FAEFD55ACB88B25E03469E43D5DB3B390BA4E36EF7185F353031171DB27C0F2782F912A252C9619D215672D8112F165947C079EEF2298B86653F204DBCCED5EC06758107B9986F0EA41D66F842EF6C139258B807822C1C8FBE327EAB0E33D7FF80F50D784EE2D380000 , N'6.4.4')
