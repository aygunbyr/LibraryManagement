using LibraryManagement.ConsoleUI;

// Kitaplar listesine yeni bir kitap ekleyip eklendikten sonra listeyi ekran çıktısı
// olarak veriniz.(Verileri kullanıcıdan alınız.)
// * Kitap eklerken Id si veya ISBN numarası daha önceki eklenen kitaplarda var ise 
// Benzersiz bir kitap girmeniz gerekmektedir yazısı çıksın.

// Kullanıcı bir Id girdiği zaman o id ye göre kitabı silen ve yeni listeyi ekrana bastıran
// kodu yazınız.


// Kullanıcıdan ilk başta id değeri alıp arama yaptıktan sonra eğer o Id ye ait
// bir kitap yoksa "İlgili Id ye ait bir kitap bulunamadı."
//* Güncellenecek olan değerler kullanıcıdan alınacak.

// Kullanıcıdan bir kitap almasını isteyen kodu yazınız 
// Eğer o kitap Stok da varsa kitap alındı yazısı çıksın 
// 1 tane varsa o kitap alınsın ve 0 olursa Listeden silinsin.



// Prime Örnekler 
// BookDetail adında bir record oluşturup şu değerler listelenecek
// Kitap Id, Kitap Başlığı , Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN ,
// Yazar Adı, Kategori Adı


// Kullanıcıdan PageIndex ve PageSize değerlerini alarak sayfalama desteği getiriniz.


//Kitaplar listesi oluşturunuz
//Yazarlar   "         "
//Kategoriler  "       "       

List<Book> books = new List<Book>()
{
    new Book(1,"Germinal","Kömür Madeni",341,"2012 Mayıs","9781234567897"),
    new Book(2,"Suç ve Ceza","Raskolnikov un hayatı",315,"2010 Haziran","9781234567891"),
    new Book(3,"Kumarbaz","Bir Öğretmenin hayatı",210,"2009 Ocak","9781234567892"),
    new Book(4, "Araba Sevdası","Arabayla alakası olmayan Kitap",180,"1999 Ocak","9781234567838"),
    new Book(5,"Ateşten Gömlek","Kurtulu savaşını anlatan kitap",120,"2001 Eylül","9781234567834"),
    new Book(6,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","9781234567845"),
    new Book(7,"28 Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak ","9781234567807"),
    new Book(8,"16 Yıl Şampiyonluk","Hayal ürünüdür.",255,"10 Eylül","9781234567800"),
    new Book(9,"Ali Arı","Uyanık Ceo nun hikayesi",551,"20 Haziran","9781234567800")
};


List<Author> authors = new List<Author>()
{
    new Author(1,"Emile","Zola"),
    new Author(2,"Fyodor","Dostoyevski"),
    new Author(3,"Recaizade Mahmut","Ekrem"),
    new Author(4, "Halide Edib","Adıvar"),
    new Author(5,"Ömer","Seyfettin"),
    new Author(6,"Ali","Koç"),
    new Author(7,"Vız vız","Ali")
};


List<Category> categories = new List<Category>()
{
    new Category(1,"Dünya Klasikleri"),
    new Category(2,"Türk Klasikleri"),
    new Category(3,"Bilim Kurgu")
};

void PrintAyirac(string metin)
{
    Console.WriteLine(metin);
    Console.WriteLine("-----------------------------------------------------------");
}

void GetAllBooks()
{
    PrintAyirac("Kitapları Listele:");
    foreach (Book book in books)
    {
        Console.WriteLine(book);
    }
}

void GetAllCategories()
{
    PrintAyirac("Kategorileri Listele:");
    foreach (Category category in categories)
    {
        Console.WriteLine(category);
    }
}

void GetAllAuthors()
{
    PrintAyirac("Yazarları Listele:");
    foreach (Author author in authors)
    {
        Console.WriteLine(author);
    }
}

void GetAllBooksByPageSizeFilter()
{
    PrintAyirac("Sayfa sayısına göre filtreleme");
    Console.WriteLine("Lütfen minimum değeri giriniz: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Lütfen maximum değeri giriniz: ");
    int max = Convert.ToInt32(Console.ReadLine());

    foreach (Book book in books)
    {
        if (book.PageSize <= max && book.PageSize >= min)
        {
            Console.WriteLine(book);
        }
    }
}

void PageSizeTotalCalculator()
{
    int total = 0;
    foreach (Book book in books)
    {
        total = total + book.PageSize;
    }
    Console.WriteLine($"Total pages: {total}");
}

void GetAllBooksByTitleContains()
{
    Console.WriteLine("Lütfen kitap başlığını giriniz: ");
    string text = Console.ReadLine();

    foreach (Book book in books)
    {
        if (book.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine(book);
        }
    }
}

void GetBookByISBN()
{
    Console.WriteLine("Lütfen ISBN numarasını giriniz: ");
    string ISBN = Console.ReadLine();
    foreach(Book book in books)
    {
        if(book.ISBN==ISBN)
        {
            Console.WriteLine(book);
        }
    }
}

Book GetBookInputs2()
{
    Console.WriteLine("Lütfen kitap ID'sini giriniz");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap açıklamasını giriniz");
    string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfa sayısını giriniz");
    int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap yayımlanma tarihini giriniz");
    string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz");
    string isbn = Console.ReadLine();

    Book book = new Book(id, title, description, pageSize, publishDate, isbn);
    return book;
}

void GetBookInputs(
    out int id,
    out string title,
    out string description,
    out int pageSize,
    out string publishDate,
    out string isbn
    )
{
    Console.WriteLine("Lütfen kitap ID'sini giriniz");
    id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz");
    title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap açıklamasını giriniz");
    description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfa sayısını giriniz");
    pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap yayımlanma tarihini giriniz");
    publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz");
    isbn = Console.ReadLine();
}

bool AddBookValidator(Book book)
{
    bool isUnique = true;

    foreach (Book item in books)
    {
        //if(item.Id == id || isbn == item.ISBN)
        if (item.Id == book.Id || item.ISBN == book.ISBN)
        {
            isUnique = false;
            break;
        }
    }
    return isUnique;
}

void Add()
{
    PrintAyirac("Kitap Ekleme: ");

    Book book = GetBookInputs2();
    bool isUnique = AddBookValidator(book);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kitap benzersiz değil.");
        return;
    }

    books.Add(book);

    GetAllBooks();
}

//GetAllBooks();
//GetAllCategories();
//GetAllAuthors();
//GetAllBooksByPageSizeFilter();
//PageSizeTotalCalculator();
//GetAllBooksByTitleContains();
//GetBookByISBN();
//Add();

bool AddCategoryValidator(Category category) {
    bool isUnique = true;
    foreach(Category item in categories)
    {
        if(item.Id == category.Id || item.Name == category.Name)
        {
            isUnique = false;
        }

    }
    return isUnique;
}

Category GetCategoryInputs()
{
    int id;
    string name;
    Console.WriteLine("Kategori Id giriniz: ");
    id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Kategori adı giriniz: ");
    name = Console.ReadLine();
    Category category = new Category(id, name);
    return category;
}
void AddCategory()
{
    PrintAyirac("Kategori Ekleme: ");
    Category category = GetCategoryInputs();
    bool isUnique = AddCategoryValidator(category);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kategori benzersiz değil.");
        return;
    }

    categories.Add(category);

    GetAllCategories();
}

bool AddAuthorValidator(Author author)
{
    bool isUnique = true;
    foreach (Author item in authors)
    {
        if (item.Id == author.Id 
            || (item.Name == author.Name && item.Surname == author.Surname)
            )
        {
            isUnique = false;
        }
    }
    return isUnique;
}

Author GetAuthorInputs()
{
    int id;
    string name;
    string surname;
    Console.WriteLine("Yazar Id giriniz: ");
    id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Yazar Adı giriniz: ");
    name = Console.ReadLine();
    Console.WriteLine("Yazar Soyadı giriniz: ");
    surname = Console.ReadLine();
    Author author = new Author(id, name, surname);
    return author;
}
void AddAuthor()
{
    PrintAyirac("Yazar Ekleme: ");
    Author author = GetAuthorInputs();
    bool isUnique = AddAuthorValidator(author);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz yazar benzersiz değil.");
        return;
    }

    authors.Add(author);

    GetAllAuthors();
}

AddCategory();
AddAuthor();