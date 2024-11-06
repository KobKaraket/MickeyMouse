namespace MickeyMouse
{
	public class Lotto
	{
		public int GUID { get; set; } = 0;
		public int LottoNumber { get; set; } = 0;
		public Guid Owner_GUID { get; set; } = Guid.Empty;
		public string Owner_FullName { get; set; } = string.Empty;
		public DateTime? TakeOwnerDateTime { get; set; } = null;

	}

	public class RandomLottoNumber
	{
		public int GUID { get; set; } = 0;
		public int LottoNumber { get; set; } = 0;
		public Guid User_GUID { get; set; } = Guid.Empty;
		public string User_FullName { get; set; } = string.Empty;
		public DateTime? ShowDateTime { get; set; } = null;	
		public DateTime? NextRefresh { get; set; } = null;
	}

	public class TransactionRandomLottoNumber
	{
		public List<RandomLottoNumber> RandomLottoNumber { get; set; }

}
