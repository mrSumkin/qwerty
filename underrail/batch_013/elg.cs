using System;
using System.Runtime.Serialization;

// Token: 0x020007E1 RID: 2017
[eiz("LXATT")]
[Serializable]
public sealed class elg : ya, ISerializable
{
	// Token: 0x06003288 RID: 12936 RVA: 0x0013A1AC File Offset: 0x001383AC
	private elg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("LXATT:P");
	}

	// Token: 0x06003289 RID: 12937 RVA: 0x0013A1C8 File Offset: 0x001383C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LXATT:P", this.a);
	}

	// Token: 0x0600328A RID: 12938 RVA: 0x0013A1E4 File Offset: 0x001383E4
	public int a()
	{
		return this.a;
	}

	// Token: 0x0600328B RID: 12939 RVA: 0x0013A1EC File Offset: 0x001383EC
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600328C RID: 12940 RVA: 0x0013A1F8 File Offset: 0x001383F8
	public elg()
	{
	}

	// Token: 0x0600328D RID: 12941 RVA: 0x0013A204 File Offset: 0x00138404
	protected override void jk(b0b A_0)
	{
		base.jk(A_0);
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Id == "azif")
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_azif_leadingPos"] = this.a;
				uk uk = new uk();
				uk.c(true);
				a4s a4s = new a4s(uk, null, null, null);
				a4s.b(new ar7(c5x));
				a4s a_ = a4s;
				c5x.Zone.ActionManager.g9(a_, atp.a);
				base.o();
			}
		}
	}

	// Token: 0x04001B04 RID: 6916
	private int a;
}
