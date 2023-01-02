using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        //public string Title { get; set; }
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "3文字以上60文字以内で入力してください")]
        [Required(ErrorMessage = "{0}は、省略することはできません")]
        [Display(Name = "タイトル")]
        public string Title { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0}は、省略することはできません")]
        [Display(Name = "リリース日")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "ジャンルの指定に誤りがあります")]
        [Required(ErrorMessage = "{0}は、省略することはできません")]
        [Display(Name = "ジャンル")]
        public string Genre { get; set; }

        [Range(1, 10000, ErrorMessage = "1から10000の間で入力してください")]
        [Required(ErrorMessage = "{0}は、省略することはできません")]
        [DisplayFormat(DataFormatString = "{0:#,0}", ApplyFormatInEditMode = true)]
        [Display(Name = "価格")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "レイティングの指定に誤りがあります")]
        [StringLength(5)]
        [Required(ErrorMessage = "{0}は、省略することはできません")]
        [Display(Name = "レイティング")]
        public string Rating { get; set; }

    }
}