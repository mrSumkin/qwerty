using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019CD RID: 6605
[eiz("BLTSE1")]
[Serializable]
public sealed class ejr : d3e, ISerializable
{
	// Token: 0x06008D89 RID: 36233 RVA: 0x003937B0 File Offset: 0x003919B0
	private ejr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D8A RID: 36234 RVA: 0x003937BC File Offset: 0x003919BC
	public ejr(double A_0)
	{
		base.Priority = int.MaxValue;
		this.a = A_0;
	}

	// Token: 0x06008D8B RID: 36235 RVA: 0x003937D8 File Offset: 0x003919D8
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null && A_0.a().Offense.u().TypedDefinition.e() == btz.a)
		{
			WeaponSubtype? weaponSubtype = euf.d(A_0.a().Offense.u().TypedDefinition);
			if (weaponSubtype != null && euf.g(weaponSubtype.Value))
			{
				A_0.a().Offense.o *= 1.0 - this.a;
			}
		}
	}

	// Token: 0x06008D8C RID: 36236 RVA: 0x0039387C File Offset: 0x00391A7C
	public override d3e b3()
	{
		ejr ejr = new ejr(this.a);
		this.xx(ejr);
		return ejr;
	}

	// Token: 0x040037BA RID: 14266
	public new double a;
}
