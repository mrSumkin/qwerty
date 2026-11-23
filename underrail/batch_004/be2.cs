using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001150 RID: 4432
[eiz("PCAC")]
[Serializable]
public sealed class be2 : ISerializable
{
	// Token: 0x06005EF0 RID: 24304 RVA: 0x00283FC0 File Offset: 0x002821C0
	private be2(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("PCAC:A", typeof(ActionReference<bgn>)) as ActionReference<bgn>);
		this.b = (atp)A_0.GetValue("PCAC:E", typeof(atp));
	}

	// Token: 0x06005EF1 RID: 24305 RVA: 0x00284014 File Offset: 0x00282214
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("PCAC:A", this.a);
		info.AddValue("PCAC:E", this.b);
	}

	// Token: 0x06005EF2 RID: 24306 RVA: 0x00284040 File Offset: 0x00282240
	public be2()
	{
	}

	// Token: 0x06005EF3 RID: 24307 RVA: 0x00284048 File Offset: 0x00282248
	public be2(ActionReference<bgn> A_0, atp A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x040025C5 RID: 9669
	public ActionReference<bgn> a;

	// Token: 0x040025C6 RID: 9670
	public atp b;
}
