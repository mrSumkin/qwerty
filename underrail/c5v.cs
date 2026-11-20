using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x0200174A RID: 5962
[eiz("TC03")]
[Serializable]
public sealed class c5v : bkj, ISerializable
{
	// Token: 0x06008075 RID: 32885 RVA: 0x003645C8 File Offset: 0x003627C8
	private c5v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008076 RID: 32886 RVA: 0x003645D4 File Offset: 0x003627D4
	protected override string om()
	{
		return "CaveEarPoisonCaltrops";
	}

	// Token: 0x06008077 RID: 32887 RVA: 0x003645DC File Offset: 0x003627DC
	public c5v()
	{
	}

	// Token: 0x06008078 RID: 32888 RVA: 0x003645E4 File Offset: 0x003627E4
	protected override arn on(c5x A_0, amc A_1, int A_2)
	{
		return new e3x(A_0, new EntityAspectReference<amc, amc>(A_1), A_2, base.vg().e().b9() as coh);
	}
}
