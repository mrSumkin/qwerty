using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000F4A RID: 3914
[e79("Xpbl_Le_DoctorHealsWounds")]
public sealed class ab5 : dgy
{
	// Token: 0x06004F36 RID: 20278 RVA: 0x0023BDE8 File Offset: 0x00239FE8
	public ab5()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("419d485d-1c39-4698-8034-5710aa1df716"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.OperateShort);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(c5x2));
					bb.b(1);
					array[num] = bb;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.Operating);
					bb2.a(atp.a);
					bb2.IsAsync = true;
					bb2.a(new ar7(c5x2));
					bb2.b(3);
					array2[num2] = bb2;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array3[num3] = dky;
					base.a(array3);
					base.a(new btm[]
					{
						new ace(new eop())
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array4[num4] = c8s;
					base.a(array4);
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx = new egx();
					egx.a("Удачного пути.");
					array5[num5] = new ace(egx)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array5);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}
}
