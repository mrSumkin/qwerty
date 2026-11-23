using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E13 RID: 3603
[e79("Tch_GeorgisSoberUp")]
public sealed class d1s : dgy
{
	// Token: 0x06004C66 RID: 19558 RVA: 0x00215A40 File Offset: 0x00213C40
	public d1s()
	{
		d1s.b b = new d1s.b();
		base..ctor();
		b.a = this;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b.b = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.b != null && b.b.Area != null)
			{
				d1s.a a = new d1s.a();
				bool flag = new ar7(new Guid("622d21d7-292e-4492-9a5e-d98182a53ef6"), b.b.Area).ao() is c5x;
				a.a = (new ar7(new Guid("567c2b97-67dd-4126-a059-bd4d5ac6143c"), b.b.Area).ao() as c5x);
				if (flag)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					if (a.a != null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array2[num2] = c8s;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx = new egx();
					egx.a("Эм, какого?.. Что это за место?");
					array3[num3] = new ace(egx)
					{
						TargetRef = new ar7(b.b)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E14 RID: 3604
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C68 RID: 19560 RVA: 0x00215C38 File Offset: 0x00213E38
		internal bool a(e6d A_0)
		{
			new eb7(new Guid?(new Guid("df873276-a3e8-4668-bd62-8c1f8434b001")), true).ym(this.b, null, null);
			a0l.a(this.b, "player_wakesUp", true);
			foreach (string g in new string[]
			{
				"0f162d9f-20c1-4bec-8e77-3ed8b883d7db",
				"2cd896ef-79dc-4702-a3bb-569d47c97578",
				"1924121b-b62c-4df2-8f63-61918026d946",
				"c3694b33-5ac3-4048-9502-dc0a817fd7e1",
				"5ba28d98-1130-4330-9caa-3b19b6872240",
				"deb8cdd9-70a0-44fb-8a2f-7b48e404fd81",
				"cf2808ae-4cbc-45e1-ab7b-814653d4bd30",
				"943b66be-9958-45a8-926b-1495eea19eb4",
				"ced56558-4a00-4419-a2cf-ac40d1ea4258",
				"a5ee0ed5-a2c2-402a-bc81-e8b2f40d5e1d",
				"4e6fc111-101e-47a6-b57b-fca2866b1eec"
			})
			{
				di6 di = this.a;
				btm[] array2 = new btm[1];
				int num = 0;
				a5 a = new a5();
				a.a(new ar7(new Guid(g), this.b.Area));
				a.c(true);
				array2[num] = a;
				di.a(array2);
			}
			return true;
		}

		// Token: 0x04001EEB RID: 7915
		public d1s a;

		// Token: 0x04001EEC RID: 7916
		public c5x b;
	}

	// Token: 0x02000E15 RID: 3605
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C6A RID: 19562 RVA: 0x00215D38 File Offset: 0x00213F38
		internal bool a(e6d A_0)
		{
			this.a.RemoveAspect<c3g>();
			return true;
		}

		// Token: 0x04001EED RID: 7917
		public c5x a;
	}
}
