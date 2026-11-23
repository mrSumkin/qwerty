using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D19 RID: 3353
[e79("Cc_StartRepairsWithVivian")]
public sealed class ds2 : dgy
{
	// Token: 0x06004A30 RID: 18992 RVA: 0x001F48C0 File Offset: 0x001F2AC0
	public ds2()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ds2.a a = new ds2.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.b = (new ar7(new Guid("ae9a9089-e9d6-4416-9b34-6ca5851683e3"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array = new btm[1];
					int num = 0;
					egx egx = new egx();
					egx.a("Вот он где. Прелестно.");
					array[num] = new ace(egx)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s = new s5();
					s.a(new ar7(a.b));
					s.a(new bt4("global:cc_vivian:repair"));
					s.IsAsync = false;
					s.a(true);
					array2[num2] = s;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(a.b));
					bb.b(2);
					array3[num3] = bb;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.a));
					s2.a(new bt4("player_talkVIvian"));
					s2.IsAsync = false;
					s2.a(true);
					array4[num4] = s2;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D1A RID: 3354
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A32 RID: 18994 RVA: 0x001F4B68 File Offset: 0x001F2D68
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D91 RID: 7569
		public c5x a;

		// Token: 0x04001D92 RID: 7570
		public c5x b;
	}
}
