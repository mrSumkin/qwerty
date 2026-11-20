using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020009B8 RID: 2488
[eiz("LUUWBD1")]
[Serializable]
public sealed class so : bdw, ISerializable
{
	// Token: 0x06003BDC RID: 15324 RVA: 0x00162180 File Offset: 0x00160380
	private so(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003BDD RID: 15325 RVA: 0x00162188 File Offset: 0x00160388
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003BDE RID: 15326 RVA: 0x0016218C File Offset: 0x0016038C
	public so()
	{
	}

	// Token: 0x06003BDF RID: 15327 RVA: 0x00162194 File Offset: 0x00160394
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b16");
			if (aud != null)
			{
				d2b d2b = new EntityAspectReference<d2b, d2b>(aud, new Guid("7447c700-c0c3-4c1c-862e-02d0e04b658c")).ao();
				if (d2b != null)
				{
					d2b.a(true, false);
				}
			}
		}
	}
}
