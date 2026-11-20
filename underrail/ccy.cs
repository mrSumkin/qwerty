using System;
using System.Runtime.Serialization;

// Token: 0x02000145 RID: 325
[eiz("SFVA")]
[Serializable]
public abstract class ccy : esc, ISerializable
{
	// Token: 0x06000804 RID: 2052 RVA: 0x00022148 File Offset: 0x00020348
	protected ccy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("SFVA:P");
			return;
		}
		if (base.GetType() == typeof(ccy))
		{
			this.a = A_0.GetString("_Path");
			return;
		}
		this.a = A_0.GetString("SetFieldValueAction+_Path");
	}

	// Token: 0x06000805 RID: 2053 RVA: 0x000221B8 File Offset: 0x000203B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SFVA:P", this.a);
	}

	// Token: 0x06000806 RID: 2054 RVA: 0x000221D4 File Offset: 0x000203D4
	public string b()
	{
		return this.a;
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x000221DC File Offset: 0x000203DC
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000808 RID: 2056 RVA: 0x000221E8 File Offset: 0x000203E8
	public ccy()
	{
	}

	// Token: 0x06000809 RID: 2057 RVA: 0x000221F4 File Offset: 0x000203F4
	public override bool h5(string A_0, bool A_1)
	{
		return base.h5(A_0, A_1) || (!string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1);
	}

	// Token: 0x0400058E RID: 1422
	private string a;
}
