using System;

// Token: 0x02000F1B RID: 3867
[e79("Xpbl_Ferry_HelpLoadNavalMines")]
public sealed class cqm : dgy
{
	// Token: 0x06004ED4 RID: 20180 RVA: 0x002365B8 File Offset: 0x002347B8
	public cqm()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v().b() is c5x)
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
				new ace(new c42())
			});
			base.a(new btm[]
			{
				new os(TimeSpan.FromSeconds(2.0))
			});
			base.a(new btm[]
			{
				new di4(new c2w("xpbl_k1", "LoadMines"), false, new bool?(false), 0, null, true, false, false)
			});
			btm[] array2 = new btm[1];
			int num2 = 0;
			egx egx = new egx();
			egx.a("Фух! Надеюсь, он сделает всё правильно.");
			array2[num2] = new ace(egx)
			{
				TargetRef = new ar7(aju.a, new Guid("1ef23235-cfea-4a4c-a032-4871b9bb2c4a"), new Guid("e819893b-3189-475b-bdf1-d77bce47bd89"), bl1.a)
			};
			base.a(array2);
			base.a(new btm[]
			{
				new ace(new e80(true))
			});
		}
	}
}
