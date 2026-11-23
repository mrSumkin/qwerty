using System;

// Token: 0x02001CF0 RID: 7408
public sealed class b4i : brl
{
	// Token: 0x0600A2B1 RID: 41649 RVA: 0x003E9BE8 File Offset: 0x003E7DE8
	public override int og()
	{
		return 1;
	}

	// Token: 0x0600A2B2 RID: 41650 RVA: 0x003E9BEC File Offset: 0x003E7DEC
	public b4i(Type A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2B3 RID: 41651 RVA: 0x003E9C00 File Offset: 0x003E7E00
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		if (A_0.Feats != null)
		{
			foreach (ai8 ai in A_0.Feats)
			{
				if (ai.GetType() != this.a && typeof(bar).IsAssignableFrom(ai.GetType()))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x0600A2B4 RID: 41652 RVA: 0x003E9CA0 File Offset: 0x003E7EA0
	public override string ToString()
	{
		return qv.b("NoOtherIncreasedBaseAbilityFeatsRequirement");
	}

	// Token: 0x04003E49 RID: 15945
	private Type a;
}
