using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x020013E6 RID: 5094
[eiz("RLLSH")]
[Serializable]
public sealed class d2h : aig, ISerializable
{
	// Token: 0x060072B9 RID: 29369 RVA: 0x00303E04 File Offset: 0x00302004
	private d2h(SerializationInfo A_0, StreamingContext A_1)
	{
		this.b = (ar7)A_0.GetValue("RLLSH:ER", typeof(ar7));
		this.c = A_0.GetSingle("RLLSH:DC");
		this.d = A_0.GetSingle("RLLSH:TC");
	}

	// Token: 0x060072BA RID: 29370 RVA: 0x00303E5C File Offset: 0x0030205C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("RLLSH:ER", this.b);
		info.AddValue("RLLSH:DC", this.c);
		info.AddValue("RLLSH:TC", this.d);
	}

	// Token: 0x060072BB RID: 29371 RVA: 0x00303E94 File Offset: 0x00302094
	public d2h(b0b A_0)
	{
		this.b = new ar7(A_0);
	}

	// Token: 0x060072BC RID: 29372 RVA: 0x00303EAC File Offset: 0x003020AC
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		this.d += A_3;
		this.c += A_3;
		if (this.d < 1f)
		{
			return false;
		}
		if (this.c >= 0.5f)
		{
			this.c -= 0.5f;
			Vector3 vector = A_1 + bnx.b(aw1.b(A_0.VisualDirection)).b() * 0.4f;
			int value = (int)((A_0.VisualDirection + 9) % (HorizontalDirection)8);
			if (this.b != null && this.b.ao() != null && this.b.ao().Area != null)
			{
				aud a_ = this.b.ao().Area;
				Vector3 a_2 = vector;
				HorizontalDirection? a_3 = null;
				string a_4 = "rocket_exhaust_smoke_" + cuo.a.Next(3).ToString();
				int a_5 = 1;
				double maxValue = double.MaxValue;
				float? a_6 = dz6.b();
				int? a_7 = new int?(value);
				boj.a(a_, a_2, a_3, a_4, a_5, maxValue, null, null, a_6, a_7);
			}
		}
		return false;
	}

	// Token: 0x04002ED8 RID: 11992
	private const float a = 0.5f;

	// Token: 0x04002ED9 RID: 11993
	private ar7 b;

	// Token: 0x04002EDA RID: 11994
	private float c;

	// Token: 0x04002EDB RID: 11995
	private float d;
}
