using System;
using System.Runtime.CompilerServices;

// Token: 0x0200033D RID: 829
[apc("jy_grover")]
public sealed class bk5 : esk
{
	// Token: 0x06001775 RID: 6005 RVA: 0x00076CC8 File Offset: 0x00074EC8
	public bk5()
	{
		this.b = new ej0(new Action<ej0>(bk5.a.a.a));
		arr[] array = new arr[2];
		array[0] = new arr(this.b, new Func<e1k, bool>(bk5.a.a.a));
		array[1] = new arr(this.c.a, null);
		this.a = new fh(array);
		this.b.a = this.c;
		this.c.a = this.a;
	}

	// Token: 0x04000DFD RID: 3581
	private new fh a;

	// Token: 0x04000DFE RID: 3582
	private new ej0 b;

	// Token: 0x0200033E RID: 830
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001778 RID: 6008 RVA: 0x00076D98 File Offset: 0x00074F98
		internal void a(ej0 A_0)
		{
			A_0.b().g().aa().PersonalAttitudes.Clear();
			new bzv(A_0.b().c().y6()).e();
			eaq eaq = new eaq();
			eaq.b(asp.a);
			eaq.a(asp.w);
			eaq.a(global::h.b);
			eaq.a(true);
			eaq.ym(null, null, null);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_jygrover_stoppedAttacking"] = true;
				if (serviceOrThrow.aqu().v() != null)
				{
					serviceOrThrow.aqu().v().PersonalAttitudes.Remove(asp.w);
				}
			}
			new cct("Подождите, пожалуйста!", true, null, bvl.c).ym(null, A_0.b().g().a8(), null);
			bpo.GetServiceOrThrow<d02>().ahs(true, false);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00076E9C File Offset: 0x0007509C
		internal bool a(e1k A_0)
		{
			if (A_0.g().aa().Defense.q().zo() <= A_0.g().aa().Defense.q().zm() / 2f)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jygrover_attacked1", new bool?(false)).Value;
					bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jygrover_attacked2", new bool?(false)).Value;
					bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jygrover_stoppedAttacking", new bool?(false)).Value;
					bool value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_jygrover_stealCoreAccepted", new bool?(false)).Value;
					if (value && !value2 && !value4 && !value3)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04000DFF RID: 3583
		public static readonly bk5.a a = new bk5.a();

		// Token: 0x04000E00 RID: 3584
		public static Action<ej0> b;

		// Token: 0x04000E01 RID: 3585
		public static Func<e1k, bool> c;
	}
}
