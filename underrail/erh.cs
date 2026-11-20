using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200027D RID: 637
[eiz("CMH")]
[Serializable]
public sealed class erh : aig, ISerializable
{
	// Token: 0x060012A2 RID: 4770 RVA: 0x0004DBE4 File Offset: 0x0004BDE4
	private erh(SerializationInfo A_0, StreamingContext A_1)
	{
		di7.ReadList<aig>("CMH:H", ref this.a, A_0);
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x0004DC08 File Offset: 0x0004BE08
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<aig>("CMH:H", this.a, info);
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x0004DC1C File Offset: 0x0004BE1C
	public List<aig> a()
	{
		return this.a;
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x0004DC24 File Offset: 0x0004BE24
	public erh()
	{
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x0004DC38 File Offset: 0x0004BE38
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		bool flag = false;
		foreach (aig aig in this.a)
		{
			flag |= aig.hj(A_0, A_1, A_2, A_3);
		}
		return flag;
	}

	// Token: 0x04000A4C RID: 2636
	private List<aig> a = new List<aig>();
}
