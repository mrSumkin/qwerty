using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A9E RID: 2718
[eiz("LUBTMJ")]
[Serializable]
public sealed class n1 : cze, ISerializable
{
	// Token: 0x06003FA8 RID: 16296 RVA: 0x00182B00 File Offset: 0x00180D00
	private n1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x00182B0C File Offset: 0x00180D0C
	public n1()
	{
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x00182B14 File Offset: 0x00180D14
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("646766CB-7675-4567-B122-F58903C2DB81"), c5x.Area).ao() as c5x;
				cij cij = new cij(c5x2);
				List<cze> list = cij.n();
				bfq bfq = new bfq("BigTntExplode");
				bfq.a(new Guid?(new Guid("9a4506f6-07a6-4cff-b4b3-f122089b0512")));
				bfq.a("lu-b29");
				list.Add(bfq);
				cij.n().Add(new a3q());
				cij.n().Add(new uk());
				c5x2.SetAspect<cij>(cij);
				bim bim = new bim(c5x2);
				bim.af2(false);
				bim.j(true);
				List<cze> list2 = bim.s();
				a72 a = new a72();
				a.b("interfacing\\lu_b29_bomb");
				list2.Add(a);
				c5x2.SetAspect<bim>(bim);
				if (c5x2 != null)
				{
					int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("trainheist_bombDistract", new int?(0)).Value;
					cij.a(new int?(120000 - value * 10000));
				}
			}
		}
	}
}
