using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001360 RID: 4960
[eiz("SFSN")]
[Serializable]
public class bw1 : aig, ISerializable
{
	// Token: 0x06007081 RID: 28801 RVA: 0x002F41C4 File Offset: 0x002F23C4
	protected bw1(SerializationInfo A_0, StreamingContext A_1)
	{
		this.b = A_0.GetSingle("SFSN:D");
	}

	// Token: 0x06007082 RID: 28802 RVA: 0x002F41E0 File Offset: 0x002F23E0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SFSN:D", this.b);
	}

	// Token: 0x06007083 RID: 28803 RVA: 0x002F41F4 File Offset: 0x002F23F4
	public bw1()
	{
	}

	// Token: 0x06007084 RID: 28804 RVA: 0x002F4200 File Offset: 0x002F2400
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		if ((this.b += A_3) >= 0.5f)
		{
			this.b -= 0.5f;
			if (A_0 != null && A_0.Area != null && A_0.Zone != null)
			{
				b0b b0b;
				auv auv = es2.a(A_1, new Vector3(A_1.X, A_1.Y, 0f), A_0.Area, "SporeTurretFlake", null, out b0b);
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

	// Token: 0x04002E09 RID: 11785
	private const float a = 0.5f;

	// Token: 0x04002E0A RID: 11786
	private float b;
}
