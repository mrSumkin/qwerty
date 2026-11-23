using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000367 RID: 871
[eiz("TAS")]
[Serializable]
public sealed class cmb : ISerializable
{
	// Token: 0x0600185B RID: 6235 RVA: 0x0007B734 File Offset: 0x00079934
	private cmb(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadDictionary<int, float>("TAS:S", ref this.a, A_0);
			if (ell.a() >= 169)
			{
				di7.ReadDictionary<int, Point>("TAS:P", ref this.b, A_0);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(cmb))
			{
				this.a = (Dictionary<int, float>)A_0.GetValue("_Set", typeof(Dictionary<int, float>));
				return;
			}
			this.a = (Dictionary<int, float>)A_0.GetValue("TargetAccessabilitySet+_Set", typeof(Dictionary<int, float>));
		}
	}

	// Token: 0x0600185C RID: 6236 RVA: 0x0007B7F4 File Offset: 0x000799F4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteDictionary<int, float>("TAS:S", this.a, info);
		di7.WriteDictionary<int, Point>("TAS:P", this.b, info);
	}

	// Token: 0x0600185D RID: 6237 RVA: 0x0007B818 File Offset: 0x00079A18
	public void a(int A_0, float A_1, Point A_2)
	{
		if (!this.a.ContainsKey(A_0))
		{
			this.a[A_0] = A_1;
			this.b[A_0] = A_2;
		}
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x0007B848 File Offset: 0x00079A48
	public float a(int A_0, out int A_1)
	{
		for (A_1 = A_0; A_1 >= 0; A_1--)
		{
			if (this.a.ContainsKey(A_1))
			{
				return this.a[A_1];
			}
		}
		return -1f;
	}

	// Token: 0x0600185F RID: 6239 RVA: 0x0007B884 File Offset: 0x00079A84
	public float b(int A_0)
	{
		int num;
		return this.a(A_0, out num);
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x0007B89C File Offset: 0x00079A9C
	public Point a(int A_0)
	{
		Point result;
		this.b.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x0007B8BC File Offset: 0x00079ABC
	public cmb()
	{
	}

	// Token: 0x04000E48 RID: 3656
	private Dictionary<int, float> a = new Dictionary<int, float>();

	// Token: 0x04000E49 RID: 3657
	private Dictionary<int, Point> b = new Dictionary<int, Point>();
}
