using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020013D6 RID: 5078
[eiz("C88")]
[Serializable]
public sealed class a6c : dvv, ISerializable
{
	// Token: 0x0600724F RID: 29263 RVA: 0x00300B64 File Offset: 0x002FED64
	private a6c(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Vector3)A_0.GetValue("C88:S", typeof(Vector3));
		this.c = (Vector3)A_0.GetValue("C88:T", typeof(Vector3));
		this.d = (A_0.GetValue("C88:A", typeof(e6z)) as e6z);
		this.a = A_0.GetString("C88:P");
		if (ell.a() >= 554)
		{
			this.e = (A_0.GetValue("C88:H", typeof(aig[])) as aig[]);
		}
	}

	// Token: 0x06007250 RID: 29264 RVA: 0x00300C1C File Offset: 0x002FEE1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("C88:S", this.b);
		info.AddValue("C88:T", this.c);
		info.AddValue("C88:A", this.d);
		info.AddValue("C88:P", this.a);
		info.AddValue("C88:H", this.e);
	}

	// Token: 0x06007251 RID: 29265 RVA: 0x00300C90 File Offset: 0x002FEE90
	public a6c(Vector3 A_0, Vector3 A_1, aud A_2, string A_3, aig[] A_4 = null)
	{
		this.d = new e6z(A_2);
		this.b = A_0;
		this.c = A_1;
		this.a = A_3;
		this.e = A_4;
	}

	// Token: 0x06007252 RID: 29266 RVA: 0x00300CC4 File Offset: 0x002FEEC4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.d != null && this.d.ao() != null && this.d.ao().Zone != null)
		{
			qy qy = new qy();
			b0b b0b;
			qy.ad().Add(es2.a(this.b, this.c, this.d.ao(), this.a, this.e, out b0b));
			if (b0b != null)
			{
				qy.ad().Add(new c7(b0b, false, false, true, false));
			}
			this.d.ao().Zone.ActionManager.g9(qy, atp.a);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002EA4 RID: 11940
	private new string a;

	// Token: 0x04002EA5 RID: 11941
	private Vector3 b;

	// Token: 0x04002EA6 RID: 11942
	private Vector3 c;

	// Token: 0x04002EA7 RID: 11943
	private e6z d;

	// Token: 0x04002EA8 RID: 11944
	private aig[] e;
}
