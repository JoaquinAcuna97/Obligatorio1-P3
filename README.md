# Obligatorio1-P3

### Comandos para NuGet Entity Framework

- **Add-Migration** – Permite agregar una migración con una modificación al esquema de la BD.
- **Drop-Database** – Elimina la base de datos que se especifique
- **Get-DbContext** – Retorna información sobre la clase de contexto
- **Scaffold-DbContext** -Permite generar una clase de contexto a partir de una base existente
- **Script-Migrations** -Genera los scripts correspondientes a las migraciones
- **Update-Database** – Actualiza la BD

## Exportar datos de SQLMS

- Generar script tareas generar scripts
- Avanzadas tipos de datos a incluir en el script -> Solo esquema -> Solo datos


## Consultas utiles de LINQ
#### LINQ query para obtener todos los autores
    var authors = books.Select(book => book.Author).Distinct();




#### LINQ query para filtrar libros por año de lanzamiento
    var filteredBooks = books.Where(book => book.ReleaseYear == yearToFilter);


#### LINQ query para ordenar autores por apellido
    var sortedAuthors = authors.OrderBy(author => GetLastName(author));


#### LINQ query para obtener la cantidad de libros escritos por cada autor
    var booksPerAuthor = books.GroupBy(book => book.Author)
                                .Select(group => new { Author = group.Key, Count = group.Count() });


#### LINQ query para obtener los autores que no tienen libros publicados
    var authorsWithNoBooks = authors.Except(booksAuthors);

#### LINQ query para obtener los libros escritos después de la fecha específica
        var booksAfterDate = books.Where(book => book.PublicationDate > specificDate);

#### LINQ query para obtener los autores que tienen más de 5 libros publicados
    var authorsWithMoreThan5Books = books.GroupBy(book => book.Author)
                                        .Where(group => group.Count() > 5)
                                        .Select(group => group.Key);

#### LINQ query para obtener los libros cuyo título contiene la palabra específica
        var filteredBooks = books.Where(book => book.Title.ToLower().Contains(searchTerm.ToLower()));

 #### LINQ query para obtener los autores cuyo nombre o apellido comienza con la letra específica
        var filteredAuthors = authors.Where(author => author.StartsWith(searchLetter.ToString(), StringComparison.OrdinalIgnoreCase));
