using System;
using System.Runtime.Serialization;

// Token: 0x02001AFC RID: 6908
[eiz("XS8")]
[Serializable]
public sealed class alf : els, ISerializable
{
	// Token: 0x0600959E RID: 38302 RVA: 0x003AAC58 File Offset: 0x003A8E58
	private alf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600959F RID: 38303 RVA: 0x003AAC64 File Offset: 0x003A8E64
	public alf(int A_0) : base(alf.a, "Псевдо-пространственная проекция", ci8.b)
	{
		base.Icon = "Status.PseudoSpatialProjection";
		base.MaxStacks = 99;
		base.VisualEffects.Add(new ud(this, "PseudoSpatialProjection"));
		base.Duration = A_0;
	}

	// Token: 0x060095A0 RID: 38304 RVA: 0x003AACB4 File Offset: 0x003A8EB4
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/PseudoSpatialProjection");
	}

	// Token: 0x0400399A RID: 14746
	public new static readonly string a = "PseudoSpatialProjection";
}
