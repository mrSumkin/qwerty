using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019AD RID: 6573
[eiz("HMME")]
[Serializable]
public sealed class mc : cdh, ISerializable
{
	// Token: 0x06008C7A RID: 35962 RVA: 0x0039133C File Offset: 0x0038F53C
	private mc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C7B RID: 35963 RVA: 0x00391348 File Offset: 0x0038F548
	public override bool ae5()
	{
		return false;
	}

	// Token: 0x06008C7C RID: 35964 RVA: 0x0039134C File Offset: 0x0038F54C
	public mc()
	{
	}

	// Token: 0x06008C7D RID: 35965 RVA: 0x00391358 File Offset: 0x0038F558
	protected override void @in(ll A_0)
	{
		if (A_0 == null || A_0.a() == null)
		{
			return;
		}
		if (!this.b(A_0.a()))
		{
			return;
		}
		A_0.a().Defense.a(DamageType.Mechanical, -cvk.a(A_0.a()));
	}

	// Token: 0x06008C7E RID: 35966 RVA: 0x003913A8 File Offset: 0x0038F5A8
	public bool a(efk A_0)
	{
		return euf.l(A_0.Offense.u()) && (euf.l(A_0.Offense.q()) || A_0.Offense.q().TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Sledgehammer) && A_0.Defense.aj() >= cvk.b;
	}

	// Token: 0x06008C7F RID: 35967 RVA: 0x00391420 File Offset: 0x0038F620
	public bool b(efk A_0)
	{
		return (euf.l(A_0.Offense.u()) || A_0.Offense.u().TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Sledgehammer) && (euf.l(A_0.Offense.q()) || A_0.Offense.q().TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Sledgehammer) && A_0.Defense.aj() >= cvk.b;
	}

	// Token: 0x06008C80 RID: 35968 RVA: 0x003914BC File Offset: 0x0038F6BC
	public override d3e b3()
	{
		mc mc = new mc();
		this.xx(mc);
		return mc;
	}
}
