namespace LibraryManagement.Dto
{
    public class BookDetailsDto
    {
        public int Id { get; set; } // Kitabın benzersiz kimlik numarası
        public string Title { get; set; } // Kitabın adı
        public string Author { get; set; } // Kitabın yazarı
        public int PublicationYear { get; set; } // Kitabın yayın yılı
        public string ISBN { get; set; } // Kitabın ISBN numarası
        public string Genre { get; set; } // Kitabın türü
        public string Publisher { get; set; } // Kitabın yayıncısı
        public int PageCount { get; set; } // Kitabın sayfa sayısı
        public string Language { get; set; } // Kitabın yazıldığı dil
        public string Summary { get; set; } // Kitabın kısa özeti
        public int AvailableCopies { get; set; } // Mevcut kopya sayısı
    }
}
