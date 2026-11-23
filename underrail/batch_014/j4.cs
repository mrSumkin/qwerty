using System;
using System.Runtime.Serialization;

// Token: 0x0200014F RID: 335
[eiz("CIC")]
[Serializable]
public abstract class j4 : dnh, ISerializable
{
	// Token: 0x0600084C RID: 2124 RVA: 0x00022EE0 File Offset: 0x000210E0
	protected j4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("CIC:P");
			this.b = A_0.GetBoolean("CIC:AD");
			return;
		}
		if (base.GetType() == typeof(j4))
		{
			this.a = A_0.GetString("_Path");
			this.b = A_0.GetBoolean("_AllowDefaulting");
			return;
		}
		this.a = A_0.GetString("ContextInquiryCondition+_Path");
		this.b = A_0.GetBoolean("ContextInquiryCondition+_AllowDefaulting");
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x00022F88 File Offset: 0x00021188
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CIC:P", this.a);
		info.AddValue("CIC:AD", this.b);
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00022FB4 File Offset: 0x000211B4
	public string d()
	{
		return this.a;
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00022FBC File Offset: 0x000211BC
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x00022FC8 File Offset: 0x000211C8
	public bool c()
	{
		return this.b;
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x00022FD0 File Offset: 0x000211D0
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00022FDC File Offset: 0x000211DC
	protected j4()
	{
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00022FF0 File Offset: 0x000211F0
	public override bool h5(string A_0, bool A_1)
	{
		return base.h5(A_0, A_1) || (!string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1);
	}

	// Token: 0x040005A6 RID: 1446
	private string a;

	// Token: 0x040005A7 RID: 1447
	private bool b = true;
}
