using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001361 RID: 4961
[eiz("LSH")]
[Serializable]
public sealed class cvz : aig, ISerializable
{
	// Token: 0x06007085 RID: 28805 RVA: 0x002F4310 File Offset: 0x002F2510
	private cvz(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.b = A_0.GetSingle("LSH:DC");
			return;
		}
		if (base.GetType() == typeof(cvz))
		{
			this.b = A_0.GetSingle("_DistanceCache");
			return;
		}
		this.b = A_0.GetSingle("LeaveSmokeHandler+_DistanceCache");
	}

	// Token: 0x06007086 RID: 28806 RVA: 0x002F437C File Offset: 0x002F257C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LSH:DC", this.b);
	}

	// Token: 0x06007087 RID: 28807 RVA: 0x002F4390 File Offset: 0x002F2590
	public cvz()
	{
	}

	// Token: 0x06007088 RID: 28808 RVA: 0x002F439C File Offset: 0x002F259C
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		if ((this.b += A_3) >= 1.5f)
		{
			this.b -= 1.5f;
			if (A_0 != null && A_0.Area != null)
			{
				aud a_ = A_0.Area;
				HorizontalDirection? a_2 = null;
				string a_3 = "Smoke";
				int a_4 = 1;
				double maxValue = double.MaxValue;
				float? a_5 = dz6.b();
				boj.a(a_, A_1, a_2, a_3, a_4, maxValue, null, null, a_5, null);
			}
		}
		return false;
	}

	// Token: 0x04002E0B RID: 11787
	private const float a = 1.5f;

	// Token: 0x04002E0C RID: 11788
	private float b;
}
