using System;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CE8 RID: 3304
[e79("Cc_DoctorHealsWounds")]
public sealed class dzh : dgy
{
	// Token: 0x060049D1 RID: 18897 RVA: 0x001EE6F4 File Offset: 0x001EC8F4
	public dzh()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("2815d3de-b07a-4182-90e4-09c4ef70517e"), c5x.Area).ao() as c5x;
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
					egx.a("Вроде всё залатала. Если что вывалится, приходите ещё! Ещё! ::Хихикает.::");
					array4[num4] = new ace(egx)
					{
						TargetRef = new ar7(c5x2)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx2 = new egx();
					egx2.a("Это было совсем не больно.");
					array5[num5] = new ace(egx2)
					{
						TargetRef = new ar7(c5x)
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
