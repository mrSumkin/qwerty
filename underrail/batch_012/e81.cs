using System;
using System.Runtime.Serialization;

// Token: 0x02001AFB RID: 6907
[eiz("NVDS")]
[Serializable]
public sealed class e81 : els, ISerializable
{
	// Token: 0x0600959A RID: 38298 RVA: 0x003AABFC File Offset: 0x003A8DFC
	private e81(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600959B RID: 38299 RVA: 0x003AAC08 File Offset: 0x003A8E08
	public override bool oa()
	{
		return false;
	}

	// Token: 0x0600959C RID: 38300 RVA: 0x003AAC0C File Offset: 0x003A8E0C
	public e81(int A_0) : base("Neurovisual Disruption", "Нейровизуальная помеха", ci8.c)
	{
		base.Icon = "Psi.NeurovisualDisruption";
		base.Duration = A_0;
		base.StaticEffects.Add(new bxi());
	}

	// Token: 0x0600959D RID: 38301 RVA: 0x003AAC4C File Offset: 0x003A8E4C
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/NeurovisualDisruption");
	}
}
