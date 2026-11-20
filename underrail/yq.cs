using System;
using System.IO;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x02000902 RID: 2306
[eiz("CCSDG")]
[Serializable]
public sealed class yq : bdw, ISerializable
{
	// Token: 0x060038F7 RID: 14583 RVA: 0x00151A68 File Offset: 0x0014FC68
	private yq(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038F8 RID: 14584 RVA: 0x00151A70 File Offset: 0x0014FC70
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x00151A74 File Offset: 0x0014FC74
	public yq()
	{
	}

	// Token: 0x060038FA RID: 14586 RVA: 0x00151A7C File Offset: 0x0014FC7C
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("cc14");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc14_l" + 2.ToString()) + ".uzl");
				aud.Zone.a(a_, 1, null);
				TypedObjectReference<b0b> typedObjectReference = new ar7(new Guid("cfc4e5d4-b219-444c-a895-3d3e7e27b208"), aud);
				ar7 ar = new ar7(new Guid("e6cf77ed-e090-44ab-96c8-11ce765e43e9"), aud);
				c5x c5x = typedObjectReference.ao() as c5x;
				c5x c5x2 = ar.ao() as c5x;
				if (c5x != null)
				{
					a0l.a(c5x, "move_zoner1", false);
					bm6 aspect = c5x.GetAspect<bm6>();
					if (aspect != null)
					{
						aspect.y6()[ddq.ay] = new bt4("move_zoner1");
					}
				}
				if (c5x2 != null)
				{
					a0l.a(c5x2, "move_zoner2", false);
					bm6 aspect2 = c5x2.GetAspect<bm6>();
					if (aspect2 != null)
					{
						aspect2.y6()[ddq.ay] = new bt4("move_zoner2");
					}
				}
			}
		}
	}
}
