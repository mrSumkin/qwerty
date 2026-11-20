using System;
using System.Runtime.Serialization;

// Token: 0x020009F2 RID: 2546
[eiz("XPBLSORSAAI")]
[Serializable]
public sealed class erw : bdw, ISerializable
{
	// Token: 0x06003CD1 RID: 15569 RVA: 0x00169368 File Offset: 0x00167568
	private erw(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetBoolean("XPBLSORSAAI:DS");
	}

	// Token: 0x06003CD2 RID: 15570 RVA: 0x00169384 File Offset: 0x00167584
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("XPBLSORSAAI:DS", this.a);
	}

	// Token: 0x06003CD3 RID: 15571 RVA: 0x00169398 File Offset: 0x00167598
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003CD4 RID: 15572 RVA: 0x001693A0 File Offset: 0x001675A0
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003CD5 RID: 15573 RVA: 0x001693AC File Offset: 0x001675AC
	public erw()
	{
	}

	// Token: 0x06003CD6 RID: 15574 RVA: 0x001693B4 File Offset: 0x001675B4
	public erw(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003CD7 RID: 15575 RVA: 0x001693C4 File Offset: 0x001675C4
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			string str = "xpbl_sorBoat_siege";
			int num = 6;
			for (int i = 1; i < num; i++)
			{
				erb.a(str + i.ToString(), A_0.g("SorBoat"));
			}
			if (this.a)
			{
				erb.a(A_1, A_0, str + cuo.a.Next(1, num).ToString(), A_0.g("SorBoat"));
			}
		}
	}

	// Token: 0x04001B9C RID: 7068
	private bool a;
}
