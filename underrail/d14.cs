using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000932 RID: 2354
[eiz("GENILIZ")]
[Serializable]
public sealed class d14 : bdw, ISerializable
{
	// Token: 0x060039BC RID: 14780 RVA: 0x00155978 File Offset: 0x00153B78
	private d14(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("GENILIZ:L");
	}

	// Token: 0x060039BD RID: 14781 RVA: 0x00155994 File Offset: 0x00153B94
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("GENILIZ:L", this.a);
	}

	// Token: 0x060039BE RID: 14782 RVA: 0x001559A8 File Offset: 0x00153BA8
	public string a()
	{
		return this.a;
	}

	// Token: 0x060039BF RID: 14783 RVA: 0x001559B0 File Offset: 0x00153BB0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060039C0 RID: 14784 RVA: 0x001559BC File Offset: 0x00153BBC
	public d14()
	{
	}

	// Token: 0x060039C1 RID: 14785 RVA: 0x001559C8 File Offset: 0x00153BC8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), A_0.y8() + "_" + this.a) + ".uzl");
			A_0.a(a_, 1, null);
		}
	}

	// Token: 0x04001B93 RID: 7059
	private string a;
}
