using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000C90 RID: 3216
[e79("Pb_DoctorHealsWounds")]
public sealed class agf : dgy
{
	// Token: 0x060048EB RID: 18667 RVA: 0x001DB9C8 File Offset: 0x001D9BC8
	public agf()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("7e25daf1-582c-4174-96e0-44384f2bd216"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(c5x2));
					bb.b(5);
					array[num] = bb;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array2[num2] = dky;
					base.a(array2);
					base.a(new btm[]
					{
						new ace(new eop())
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array3[num3] = c8s;
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx = new egx();
					egx.a("Берегите себя, капрал.");
					array4[num4] = new ace(egx)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}
}
