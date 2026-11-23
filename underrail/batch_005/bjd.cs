using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000E3E RID: 3646
[e79("Sgs_LenoxAndBretFight")]
public sealed class bjd : dgy
{
	// Token: 0x06004CBB RID: 19643 RVA: 0x0021A054 File Offset: 0x00218254
	public bjd()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				bjd.a a = new bjd.a();
				a.a = (new ar7(new Guid("364dff75-b81b-42b6-9fcd-6faec86ffe3a"), c5x.Area).ao() as c5x);
				c5x c5x2 = new ar7(new Guid("81364897-773f-467a-9aa7-b592fb390788"), c5x.Area).ao() as c5x;
				if (a.a != null && c5x2 != null)
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
					kw kw = new kw();
					kw.a(new bt4("StationAlpha-Level8", new Vector3(9f, 21f, 0f)));
					kw.a(false);
					array[num] = kw;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					egx egx = new egx();
					egx.a("::Ленокс допивает последний глоток из стакана. Затем разбивает его об пол, чем привлекает внимание Брета.::");
					array2[num2] = new ace(egx)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx2 = new egx();
					egx2.a("Ленокс? Ты чего?!");
					array3[num3] = new ace(egx2)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx3 = new egx();
					egx3.a("Э-э... ты ублюдок... ублюдский мокрушник. Отнял две жизни своими грязными ручищами!");
					array4[num4] = new ace(egx3)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx4 = new egx();
					egx4.a("Ты что болтаешь, идиот?! Ты пьян! Иди прос...");
					array5[num5] = new ace(egx4)
					{
						TargetRef = new ar7(a.a)
					};
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx5 = new egx();
					egx5.a("::Он рычит в ответ.:: Заткнись! Заткнись! Заткнись, грязный убийца!");
					array6[num6] = new ace(egx5)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx6 = new egx();
					egx6.a("Патрик, я... отомщу за тебя!");
					array7[num7] = new ace(egx6)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array7);
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

	// Token: 0x02000E3F RID: 3647
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CBD RID: 19645 RVA: 0x0021A3E4 File Offset: 0x002185E4
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x0021A3F4 File Offset: 0x002185F4
		internal bool a(e6d A_0)
		{
			amc aspect = this.a.GetAspect<amc>();
			if (aspect != null)
			{
				aspect.aa().FactionId = "sgs_bret";
			}
			return true;
		}

		// Token: 0x04001F34 RID: 7988
		public c5x a;
	}
}
