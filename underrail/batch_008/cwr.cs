using System;
using System.Runtime.Serialization;

// Token: 0x02000FE2 RID: 4066
[eiz("ZTA")]
[Serializable]
public sealed class cwr : esc, ISerializable
{
	// Token: 0x060053BA RID: 21434 RVA: 0x002515B0 File Offset: 0x0024F7B0
	private cwr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (c2w)A_0.GetValue("ZTA:D", typeof(c2w));
			return;
		}
		if (base.GetType() == typeof(cwr))
		{
			this.a = (c2w)A_0.GetValue("_Destination", typeof(c2w));
			return;
		}
		this.a = (c2w)A_0.GetValue("ZoneTransitionAction+_Destination", typeof(c2w));
	}

	// Token: 0x060053BB RID: 21435 RVA: 0x00251658 File Offset: 0x0024F858
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZTA:D", this.a);
	}

	// Token: 0x060053BC RID: 21436 RVA: 0x00251674 File Offset: 0x0024F874
	public c2w a()
	{
		return this.a;
	}

	// Token: 0x060053BD RID: 21437 RVA: 0x0025167C File Offset: 0x0024F87C
	public void a(c2w A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060053BE RID: 21438 RVA: 0x00251688 File Offset: 0x0024F888
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null && service.aqu().v() != null && service.aqu().v().b() != null)
		{
			a0l.a(service.aqu().v().b() as c5x, this.a, 0, null);
		}
		return 0;
	}

	// Token: 0x060053BF RID: 21439 RVA: 0x002516FC File Offset: 0x0024F8FC
	public cwr()
	{
	}

	// Token: 0x04002221 RID: 8737
	private c2w a = new c2w();
}
