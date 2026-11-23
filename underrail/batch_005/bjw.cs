using System;
using System.Runtime.Serialization;

// Token: 0x02000FD9 RID: 4057
[eiz("ATA")]
[Serializable]
public sealed class bjw : esc, ISerializable
{
	// Token: 0x0600537C RID: 21372 RVA: 0x002508E4 File Offset: 0x0024EAE4
	private bjw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("ATA:DW");
			return;
		}
		if (base.GetType() == typeof(bjw))
		{
			this.a = A_0.GetString("_DestinationWaypoint");
			return;
		}
		this.a = A_0.GetString("AreaTransitionAction+_DestinationWaypoint");
	}

	// Token: 0x0600537D RID: 21373 RVA: 0x00250954 File Offset: 0x0024EB54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ATA:DW", this.a);
	}

	// Token: 0x0600537E RID: 21374 RVA: 0x00250970 File Offset: 0x0024EB70
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x00250978 File Offset: 0x0024EB78
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005380 RID: 21376 RVA: 0x00250984 File Offset: 0x0024EB84
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk service = bpo.GetService<cnk>();
		if (!string.IsNullOrEmpty(this.a) && service != null && service.aqu() != null && service.aqu().v() != null && service.aqu().v().b() != null)
		{
			a0l.a(service.aqu().v().b() as c5x, this.a, true);
		}
		return 0;
	}

	// Token: 0x06005381 RID: 21377 RVA: 0x00250A00 File Offset: 0x0024EC00
	public bjw()
	{
	}

	// Token: 0x04002211 RID: 8721
	private string a;
}
