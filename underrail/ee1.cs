using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001362 RID: 4962
[eiz("IFS")]
[Serializable]
public class ee1 : aig, ISerializable
{
	// Token: 0x06007089 RID: 28809 RVA: 0x002F4434 File Offset: 0x002F2634
	protected ee1(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.b = A_0.GetSingle("IFS:DC");
			return;
		}
		if (base.GetType() == typeof(ee1))
		{
			this.b = A_0.GetSingle("_DistanceCache");
			return;
		}
		this.b = A_0.GetSingle("IceFlakeSpawner+_DistanceCache");
	}

	// Token: 0x0600708A RID: 28810 RVA: 0x002F44A0 File Offset: 0x002F26A0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IFS:DC", this.b);
	}

	// Token: 0x0600708B RID: 28811 RVA: 0x002F44B4 File Offset: 0x002F26B4
	public ee1()
	{
	}

	// Token: 0x0600708C RID: 28812 RVA: 0x002F44C0 File Offset: 0x002F26C0
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		if ((this.b += A_3) >= 1f)
		{
			this.b -= 1f;
			if (A_0 != null && A_0.Area != null && A_0.Zone != null)
			{
				b0b b0b;
				auv auv = es2.a(A_1, new Vector3(A_1.X, A_1.Y, 0f), A_0.Area, "IceFlake", null, out b0b);
				if (b0b != null && auv != null)
				{
					e4o e4o = new e4o(b0b as c5x);
					e4o.a(200);
					e4o.b(0);
					e4o.a(dz6.a(0.3));
					qy qy = new qy();
					qy.ad().Add(e4o);
					qy.ad().Add(new c7(b0b, false, false, true, false));
					A_0.Zone.ActionManager.g9(auv, atp.a);
					A_0.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
		return false;
	}

	// Token: 0x04002E0D RID: 11789
	private const float a = 1f;

	// Token: 0x04002E0E RID: 11790
	private float b;
}
