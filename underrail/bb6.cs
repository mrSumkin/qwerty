using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x02001305 RID: 4869
[eiz("RCEA")]
[Serializable]
public sealed class bb6 : Aspect<c5x>, ISerializable
{
	// Token: 0x06006CCB RID: 27851 RVA: 0x002D8778 File Offset: 0x002D6978
	private bb6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<cze>("RCEA:OTJ", ref this.a, A_0);
			return;
		}
		di7.ReadList<cze>("RCEA_OTJ", ref this.a, A_0);
	}

	// Token: 0x06006CCC RID: 27852 RVA: 0x002D87C8 File Offset: 0x002D69C8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("RCEA:OTJ", this.a, info);
	}

	// Token: 0x06006CCD RID: 27853 RVA: 0x002D87E4 File Offset: 0x002D69E4
	public List<cze> a()
	{
		return this.a;
	}

	// Token: 0x06006CCE RID: 27854 RVA: 0x002D87EC File Offset: 0x002D69EC
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006CCF RID: 27855 RVA: 0x002D87F8 File Offset: 0x002D69F8
	public bb6(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006CD0 RID: 27856 RVA: 0x002D8810 File Offset: 0x002D6A10
	public void a(amc A_0, c5x A_1, h A_2, h A_3)
	{
		if (this.a != null)
		{
			foreach (cze cze in this.a)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary[dmh.a] = A_1;
				dictionary[dmh.b] = A_2;
				dictionary[dmh.c] = A_3;
				cze.ym((A_0 != null) ? A_0.a8() : null, base.a8(), dictionary);
			}
		}
	}

	// Token: 0x04002C9C RID: 11420
	private List<cze> a = new List<cze>();
}
