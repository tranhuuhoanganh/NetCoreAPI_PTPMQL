using System.ComponentModel.DataAnnotations;

public class HeThongPhanPhoi
{
    [Key] // Đánh dấu đây là khóa chính
    public int Id { get; set; }

    public string TenHeThong { get; set; }
    public string DiaChi { get; set; }
}
