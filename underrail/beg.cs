using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AD0 RID: 2768
[eiz("XPBLLEPORIMJ")]
[Serializable]
public sealed class beg : cze, ISerializable
{
	// Token: 0x06004091 RID: 16529 RVA: 0x001893B8 File Offset: 0x001875B8
	private beg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("XPBLLEPORIMJ:PM");
	}

	// Token: 0x06004092 RID: 16530 RVA: 0x001893D4 File Offset: 0x001875D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLLEPORIMJ:PM", this.a);
	}

	// Token: 0x06004093 RID: 16531 RVA: 0x001893F0 File Offset: 0x001875F0
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06004094 RID: 16532 RVA: 0x001893F8 File Offset: 0x001875F8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004095 RID: 16533 RVA: 0x00189404 File Offset: 0x00187604
	public beg()
	{
	}

	// Token: 0x06004096 RID: 16534 RVA: 0x0018940C File Offset: 0x0018760C
	public beg(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004097 RID: 16535 RVA: 0x00189420 File Offset: 0x00187620
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (string a_ in new List<string>
			{
				"xpbl_c5",
				"xpbl_c6",
				"xpbl_c7",
				"xpbl_d7",
				"xpbl_e7",
				"xpbl_f7",
				"xpbl_f6",
				"xpbl_f5"
			})
			{
				serviceOrThrow.aqu().a(new bw0(a_, new c4d(this.a), 1));
				if (this.a)
				{
					serviceOrThrow.aqu().r()["loc_xpbl_le_campHasMines"] = true;
				}
				else
				{
					serviceOrThrow.aqu().r()["loc_xpbl_le_campHasMines"] = false;
				}
			}
		}
	}

	// Token: 0x04001C01 RID: 7169
	private new bool a;
}
