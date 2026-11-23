using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common;

// Token: 0x02001356 RID: 4950
[eiz("POEFTA")]
[Serializable]
public sealed class clw : b1z, ISerializable
{
	// Token: 0x06007009 RID: 28681 RVA: 0x002F07C8 File Offset: 0x002EE9C8
	private clw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<Point>("POEFTA:TL", ref this.a, A_0);
			this.b = (e6z)A_0.GetValue("POEFTA:AR", typeof(e6z));
			this.c = (Axis)A_0.GetValue("POEFTA:POAA", typeof(Axis));
			this.d = A_0.GetBoolean("POEFTA:POGE");
			di7.ReadList<Guid>("POEFTA:EE", ref this.e, A_0);
			return;
		}
		if (base.GetType() == typeof(clw))
		{
			this.a = (List<Point>)A_0.GetValue("_TileLocations", typeof(List<Point>));
			this.b = (e6z)A_0.GetValue("_AreaRef", typeof(e6z));
			this.c = (Axis)A_0.GetValue("_PushOutAlongAxis", typeof(Axis));
			this.d = A_0.GetBoolean("_PushOutGroundEntities");
			this.e = (List<Guid>)A_0.GetValue("_ExcludedEntites", typeof(List<Guid>));
			return;
		}
		this.a = (List<Point>)A_0.GetValue("PushOutEntitiesFromTilesAction+_TileLocations", typeof(List<Point>));
		this.b = (e6z)A_0.GetValue("PushOutEntitiesFromTilesAction+_AreaRef", typeof(e6z));
		this.c = (Axis)A_0.GetValue("PushOutEntitiesFromTilesAction+_PushOutAlongAxis", typeof(Axis));
		this.d = A_0.GetBoolean("PushOutEntitiesFromTilesAction+_PushOutGroundEntities");
		this.e = (List<Guid>)A_0.GetValue("PushOutEntitiesFromTilesAction+_ExcludedEntites", typeof(List<Guid>));
	}

	// Token: 0x0600700A RID: 28682 RVA: 0x002F09B0 File Offset: 0x002EEBB0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Point>("POEFTA:TL", this.a, info);
		info.AddValue("POEFTA:AR", this.b);
		info.AddValue("POEFTA:POAA", this.c);
		info.AddValue("POEFTA:POGE", this.d);
		di7.WriteList<Guid>("POEFTA:EE", this.e, info);
	}

	// Token: 0x0600700B RID: 28683 RVA: 0x002F0A20 File Offset: 0x002EEC20
	public e6z c()
	{
		return this.b;
	}

	// Token: 0x0600700C RID: 28684 RVA: 0x002F0A28 File Offset: 0x002EEC28
	public void a(e6z A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600700D RID: 28685 RVA: 0x002F0A34 File Offset: 0x002EEC34
	public List<Point> a()
	{
		return this.a;
	}

	// Token: 0x0600700E RID: 28686 RVA: 0x002F0A3C File Offset: 0x002EEC3C
	public Axis d()
	{
		return this.c;
	}

	// Token: 0x0600700F RID: 28687 RVA: 0x002F0A44 File Offset: 0x002EEC44
	public void a(Axis A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06007010 RID: 28688 RVA: 0x002F0A50 File Offset: 0x002EEC50
	public bool b()
	{
		return this.d;
	}

	// Token: 0x06007011 RID: 28689 RVA: 0x002F0A58 File Offset: 0x002EEC58
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06007012 RID: 28690 RVA: 0x002F0A64 File Offset: 0x002EEC64
	public List<Guid> e()
	{
		return this.e;
	}

	// Token: 0x06007013 RID: 28691 RVA: 0x002F0A6C File Offset: 0x002EEC6C
	public clw()
	{
	}

	// Token: 0x06007014 RID: 28692 RVA: 0x002F0A8C File Offset: 0x002EEC8C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.b == null || this.b.ao() == null || this.c == Axis.Z)
		{
			return dc4.e;
		}
		if (this.a != null)
		{
			HashSet<b0b> hashSet = new HashSet<b0b>();
			foreach (Point point in this.a)
			{
				ak1 ak = this.b.ao().b(point.X, point.Y);
				if (ak != null)
				{
					foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
					{
						if (b0b.Layer != 0 && !b0b.IsFloor && !hashSet.Contains(b0b) && !b0b.aa)
						{
							hashSet.Add(b0b);
							if ((this.e() == null || !this.e().Contains(b0b.qe())) && (this.d || !b0b.IsGround) && (b0b.TileFormationModifiers.b(2L) || b0b.z != null))
							{
								double num;
								if (this.c == Axis.X)
								{
									num = (double)(b0b.Location.X + b0b.Size.X - (float)(point.X + 1) - ((float)point.X - b0b.Location.X));
								}
								else
								{
									num = (double)(b0b.Location.Y + b0b.Size.Y - (float)(point.Y + 1) - ((float)point.Y - b0b.Location.Y));
								}
								if (num == 0.0)
								{
									num = (double)((new Random().NextDouble() < 0.5) ? -1 : 1);
								}
								if (this.c == Axis.X)
								{
									if (num < 0.0)
									{
										b0b.Location = new Vector3((float)ak.Location.X - b0b.Size.X, b0b.Location.Y, b0b.Location.Z);
									}
									else
									{
										b0b.Location = new Vector3((float)(ak.Location.X + 1), b0b.Location.Y, b0b.Location.Z);
									}
								}
								else if (num < 0.0)
								{
									b0b.Location = new Vector3(b0b.Location.X, (float)ak.Location.Y - b0b.Size.Y, b0b.Location.Z);
								}
								else
								{
									b0b.Location = new Vector3(b0b.Location.X, (float)(ak.Location.Y + 1), b0b.Location.Z);
								}
								b0b.ah();
							}
						}
					}
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x04002DC4 RID: 11716
	private new List<Point> a = new List<Point>();

	// Token: 0x04002DC5 RID: 11717
	private e6z b;

	// Token: 0x04002DC6 RID: 11718
	private Axis c;

	// Token: 0x04002DC7 RID: 11719
	private bool d;

	// Token: 0x04002DC8 RID: 11720
	private List<Guid> e = new List<Guid>();
}
