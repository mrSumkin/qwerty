using System;

// Token: 0x02001F7A RID: 8058
public abstract class a6u : ehl
{
	// Token: 0x0600BCAA RID: 48298 RVA: 0x004169F8 File Offset: 0x00414BF8
	public override bool vi()
	{
		return true;
	}

	// Token: 0x0600BCAB RID: 48299 RVA: 0x004169FC File Offset: 0x00414BFC
	protected override float te(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			double num = A_0.b8().Offense.y();
			dng dng = A_0.b9() as dng;
			if (dng != null && eub.e(dng.TypedDefinition.b()))
			{
				num *= A_0.b8().Offense.at();
			}
			if (dng != null && eub.c(dng.TypedDefinition.b()))
			{
				num *= A_0.b8().Offense.ad();
			}
			if (dng != null && eub.b(dng.TypedDefinition.b()))
			{
				num *= A_0.b8().Offense.ac();
			}
			return (float)Math.Max(0.2, num);
		}
		return 1f;
	}

	// Token: 0x0600BCAC RID: 48300 RVA: 0x00416AD8 File Offset: 0x00414CD8
	protected override float cl(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			double num = A_0.b8().Offense.y();
			cd1 cd = A_0.ca() as cd1;
			if (cd != null && cd.TypedDefinition != null && cd.TypedDefinition.r() != 1.0)
			{
				num *= cd.TypedDefinition.r();
			}
			eh7 eh = A_0.ca() as eh7;
			if (eh != null && eh.a() != null && eh.a().Offense.u().TypedDefinition.r() != 1.0)
			{
				num *= eh.a().Offense.u().TypedDefinition.r();
			}
			dng dng = A_0.b9() as dng;
			if (dng != null && eub.e(dng.TypedDefinition.b()))
			{
				num *= A_0.b8().Offense.at();
			}
			if (dng != null && eub.c(dng.TypedDefinition.b()))
			{
				num *= A_0.b8().Offense.ad();
			}
			if (dng != null && eub.b(dng.TypedDefinition.b()))
			{
				num *= A_0.b8().Offense.ac();
			}
			return (float)num;
		}
		return 1f;
	}
}
