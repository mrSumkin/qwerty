using System;

// Token: 0x02001CEF RID: 7407
public sealed class crf : brl
{
	// Token: 0x0600A2AD RID: 41645 RVA: 0x003E9B24 File Offset: 0x003E7D24
	public override int og()
	{
		return 1;
	}

	// Token: 0x0600A2AE RID: 41646 RVA: 0x003E9B28 File Offset: 0x003E7D28
	public crf(Type A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600A2AF RID: 41647 RVA: 0x003E9B3C File Offset: 0x003E7D3C
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		if (A_0.Feats != null)
		{
			foreach (ai8 ai in A_0.Feats)
			{
				if (ai.GetType() != this.a && typeof(ci4).IsAssignableFrom(ai.GetType()))
				{
					return false;
				}
			}
			return true;
		}
		return true;
	}

	// Token: 0x0600A2B0 RID: 41648 RVA: 0x003E9BDC File Offset: 0x003E7DDC
	public override string ToString()
	{
		return qv.b("NoOtherEmpoweredInvocationFeatsRequirement");
	}

	// Token: 0x04003E48 RID: 15944
	private Type a;
}
