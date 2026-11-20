using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001084 RID: 4228
[eiz("PRVHJ")]
[Serializable]
public sealed class cfy : cze
{
	// Token: 0x06005823 RID: 22563 RVA: 0x0026464C File Offset: 0x0026284C
	private cfy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PRVHJ:M");
		this.b = A_0.GetString("PRVHJ:F");
	}

	// Token: 0x06005824 RID: 22564 RVA: 0x00264678 File Offset: 0x00262878
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PRVHJ:M", this.a);
		info.AddValue("PRVHJ:F", this.b);
	}

	// Token: 0x06005825 RID: 22565 RVA: 0x002646A4 File Offset: 0x002628A4
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06005826 RID: 22566 RVA: 0x002646AC File Offset: 0x002628AC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005827 RID: 22567 RVA: 0x002646B8 File Offset: 0x002628B8
	public string a()
	{
		return this.b;
	}

	// Token: 0x06005828 RID: 22568 RVA: 0x002646C0 File Offset: 0x002628C0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005829 RID: 22569 RVA: 0x002646CC File Offset: 0x002628CC
	public cfy()
	{
	}

	// Token: 0x0600582A RID: 22570 RVA: 0x002646D8 File Offset: 0x002628D8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqw() != null && serviceOrThrow.aqu() != null)
		{
			List<csd> list = new List<csd>();
			List<csd> list2 = new List<csd>();
			foreach (csd csd in serviceOrThrow.aqw().Waypoints)
			{
				if (csd.Name.StartsWith("ParkingSpace_"))
				{
					list2.Add(csd);
					if (csd.Tile != null && this.a(csd.Tile))
					{
						list.Add(csd);
					}
				}
			}
			if (list.Count > 0)
			{
				foreach (aud aud in serviceOrThrow.aqw().Areas)
				{
					foreach (b0b b0b in aud.Entities)
					{
						c5x c5x = (c5x)b0b;
						wv wv = c5x.GetAspect<bim>() as wv;
						if (wv != null && wv.g() != null && wv.g().l().Contains(this.b))
						{
							bool flag = false;
							foreach (csd csd2 in list2)
							{
								if (csd2.Area == aud && csd2.Location == c5x.Location)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								csd csd3 = list[0];
								list.RemoveAt(0);
								c5x.Location = csd3.Location;
								c5x.VisualDirection = csd3.Direction;
								c5x.ah();
								if (list.Count == 0)
								{
									return;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600582B RID: 22571 RVA: 0x00264964 File Offset: 0x00262B64
	private bool a(ak1 A_0)
	{
		foreach (b0b b0b in A_0.Entities)
		{
			c5x c5x = (c5x)b0b;
			if (c5x.z != null)
			{
				return false;
			}
			if (this.a)
			{
				if (!c5x.TileFormationModifiers.c(64L) || c5x.TileFormationModifiers.c(262144L))
				{
					return false;
				}
			}
			else if (c5x.TileFormationModifiers.c(2L))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x04002391 RID: 9105
	private new bool a;

	// Token: 0x04002392 RID: 9106
	private string b;
}
