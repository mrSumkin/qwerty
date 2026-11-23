using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E74 RID: 7796
[ayj("spyUnderDoor")]
public sealed class cqp : m0
{
	// Token: 0x0600ADA0 RID: 44448 RVA: 0x003FB6E8 File Offset: 0x003F98E8
	public override string y8()
	{
		return "Spy";
	}

	// Token: 0x0600ADA1 RID: 44449 RVA: 0x003FB6F0 File Offset: 0x003F98F0
	public override string os()
	{
		return "spyUnderDoor";
	}

	// Token: 0x0600ADA2 RID: 44450 RVA: 0x003FB6F8 File Offset: 0x003F98F8
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600ADA3 RID: 44451 RVA: 0x003FB6FC File Offset: 0x003F98FC
	public override string c1()
	{
		return "Шпионит";
	}

	// Token: 0x0600ADA4 RID: 44452 RVA: 0x003FB704 File Offset: 0x003F9904
	public override bool hl()
	{
		return false;
	}

	// Token: 0x0600ADA5 RID: 44453 RVA: 0x003FB708 File Offset: 0x003F9908
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600ADA7 RID: 44455 RVA: 0x003FB714 File Offset: 0x003F9914
	public override string bm(cnm A_0)
	{
		return "Abilities.80";
	}

	// Token: 0x0600ADA8 RID: 44456 RVA: 0x003FB71C File Offset: 0x003F991C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.SpyableDoor;
	}

	// Token: 0x0600ADA9 RID: 44457 RVA: 0x003FB720 File Offset: 0x003F9920
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600ADAA RID: 44458 RVA: 0x003FB72C File Offset: 0x003F992C
	public override string bp(cnm A_0)
	{
		int num = cqp.a(A_0);
		if (num > 0)
		{
			return qv.a("Items\\Utilities/SpyUnderDoorNightvision", new object[]
			{
				num
			});
		}
		return qv.b("Items\\Utilities/SpyUnderDoor");
	}

	// Token: 0x0600ADAB RID: 44459 RVA: 0x003FB76C File Offset: 0x003F996C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600ADAC RID: 44460 RVA: 0x003FB774 File Offset: 0x003F9974
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600ADAD RID: 44461 RVA: 0x003FB77C File Offset: 0x003F997C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600ADAE RID: 44462 RVA: 0x003FB780 File Offset: 0x003F9980
	public new static int a(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null)
			{
				return coh.CustomProperties.GetPrimitivePropertyValue<int>("EnergyCost", new int?(0)).Value;
			}
		}
		return 0;
	}

	// Token: 0x0600ADAF RID: 44463 RVA: 0x003FB7C8 File Offset: 0x003F99C8
	protected override int br(cnm A_0)
	{
		return 4000;
	}

	// Token: 0x0600ADB0 RID: 44464 RVA: 0x003FB7D0 File Offset: 0x003F99D0
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}
}
