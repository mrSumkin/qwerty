using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

namespace TimelapseVertigo.Playfield.CustomLogic.Data
{
	// Token: 0x02002233 RID: 8755
	[eiz("SRCD")]
	[Serializable]
	public sealed class ShootingRangeConsoleData : ISerializable
	{
		// Token: 0x0600CB1A RID: 51994 RVA: 0x0047E070 File Offset: 0x0047C270
		private ShootingRangeConsoleData(SerializationInfo info, StreamingContext ctx)
		{
			if (ell.a() != 0)
			{
				di7.ReadList<csk>("SRCD:D", ref this._Damages, info);
				this._ShootingBootLocation = (Point)info.GetValue("SRCD:SBL", typeof(Point));
				this._TargetEntityId = (Guid)info.GetValue("SRCD:TEI", typeof(Guid));
				this._SessionActive = info.GetBoolean("SRCD:SA");
				this._Hits = info.GetInt32("SRCD:H");
				this._Misses = info.GetInt32("SRCD:M");
				return;
			}
			if (base.GetType() == typeof(ShootingRangeConsoleData))
			{
				this._Damages = (List<csk>)info.GetValue("_Damages", typeof(List<csk>));
				this._ShootingBootLocation = (Point)info.GetValue("<ShootingBootLocation>k__BackingField", typeof(Point));
				this._TargetEntityId = (Guid)info.GetValue("<TargetEntityId>k__BackingField", typeof(Guid));
				this._SessionActive = info.GetBoolean("<SessionActive>k__BackingField");
				this._Hits = info.GetInt32("<Hits>k__BackingField");
				this._Misses = info.GetInt32("<Misses>k__BackingField");
				return;
			}
			this._Damages = (List<csk>)info.GetValue("ShootingRangeConsoleData+_Damages", typeof(List<csk>));
			this._ShootingBootLocation = (Point)info.GetValue("ShootingRangeConsoleData+<ShootingBootLocation>k__BackingField", typeof(Point));
			this._TargetEntityId = (Guid)info.GetValue("ShootingRangeConsoleData+<TargetEntityId>k__BackingField", typeof(Guid));
			this._SessionActive = info.GetBoolean("ShootingRangeConsoleData+<SessionActive>k__BackingField");
			this._Hits = info.GetInt32("ShootingRangeConsoleData+<Hits>k__BackingField");
			this._Misses = info.GetInt32("ShootingRangeConsoleData+<Misses>k__BackingField");
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x0047E260 File Offset: 0x0047C460
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
			di7.WriteList<csk>("SRCD:D", this._Damages, info);
			info.AddValue("SRCD:SBL", this._ShootingBootLocation);
			info.AddValue("SRCD:TEI", this._TargetEntityId);
			info.AddValue("SRCD:SA", this._SessionActive);
			info.AddValue("SRCD:H", this._Hits);
			info.AddValue("SRCD:M", this._Misses);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600CB1C RID: 51996 RVA: 0x0047E2E0 File Offset: 0x0047C4E0
		public List<csk> Damages
		{
			get
			{
				return this._Damages;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600CB1D RID: 51997 RVA: 0x0047E2E8 File Offset: 0x0047C4E8
		// (set) Token: 0x0600CB1E RID: 51998 RVA: 0x0047E2F0 File Offset: 0x0047C4F0
		public Point ShootingBootLocation
		{
			get
			{
				return this._ShootingBootLocation;
			}
			set
			{
				this._ShootingBootLocation = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x0047E2FC File Offset: 0x0047C4FC
		// (set) Token: 0x0600CB20 RID: 52000 RVA: 0x0047E304 File Offset: 0x0047C504
		public Guid TargetEntityId
		{
			get
			{
				return this._TargetEntityId;
			}
			set
			{
				this._TargetEntityId = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x0047E310 File Offset: 0x0047C510
		// (set) Token: 0x0600CB22 RID: 52002 RVA: 0x0047E318 File Offset: 0x0047C518
		public bool SessionActive
		{
			get
			{
				return this._SessionActive;
			}
			set
			{
				this._SessionActive = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600CB23 RID: 52003 RVA: 0x0047E324 File Offset: 0x0047C524
		public int TotalShots
		{
			get
			{
				return this.Hits + this.Misses;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600CB24 RID: 52004 RVA: 0x0047E334 File Offset: 0x0047C534
		// (set) Token: 0x0600CB25 RID: 52005 RVA: 0x0047E33C File Offset: 0x0047C53C
		public int Hits
		{
			get
			{
				return this._Hits;
			}
			set
			{
				this._Hits = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600CB26 RID: 52006 RVA: 0x0047E348 File Offset: 0x0047C548
		public int HitsPercentage
		{
			get
			{
				if (this.TotalShots == 0)
				{
					return 0;
				}
				return Convert.ToInt32((double)this.Hits / (double)this.TotalShots * 100.0);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x0047E378 File Offset: 0x0047C578
		// (set) Token: 0x0600CB28 RID: 52008 RVA: 0x0047E380 File Offset: 0x0047C580
		public int Misses
		{
			get
			{
				return this._Misses;
			}
			set
			{
				this._Misses = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x0047E38C File Offset: 0x0047C58C
		public int MissesPercentage
		{
			get
			{
				if (this.TotalShots == 0)
				{
					return 0;
				}
				return Convert.ToInt32((double)this.Misses / (double)this.TotalShots * 100.0);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600CB2A RID: 52010 RVA: 0x0047E3BC File Offset: 0x0047C5BC
		public int AverageDamage
		{
			get
			{
				if (this._Damages != null && this._Damages.Count > 0)
				{
					return Convert.ToInt32(Enumerable.Average<csk>(this._Damages, (csk d) => d.Amount));
				}
				return 0;
			}
		}

		// Token: 0x0600CB2B RID: 52011 RVA: 0x0047E41C File Offset: 0x0047C61C
		public ShootingRangeConsoleData()
		{
		}

		// Token: 0x0600CB2C RID: 52012 RVA: 0x0047E430 File Offset: 0x0047C630
		public void EndSession()
		{
			this.SessionActive = false;
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x0047E43C File Offset: 0x0047C63C
		public void StartSession()
		{
			this.SessionActive = true;
			this.Hits = 0;
			this.Misses = 0;
			this._Damages = new List<csk>();
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x0047E460 File Offset: 0x0047C660
		public static ShootingRangeConsoleData ExtractFromEntity(b0b entity)
		{
			a3f aspect = entity.GetAspect<a3f>();
			if (aspect != null && aspect.a() != null)
			{
				return aspect.a().GetClassPropertyValue<ShootingRangeConsoleData>("ShootingRangeConsoleData");
			}
			return null;
		}

		// Token: 0x04004B5C RID: 19292
		private List<csk> _Damages = new List<csk>();

		// Token: 0x04004B5D RID: 19293
		private Point _ShootingBootLocation;

		// Token: 0x04004B5E RID: 19294
		private Guid _TargetEntityId;

		// Token: 0x04004B5F RID: 19295
		private bool _SessionActive;

		// Token: 0x04004B60 RID: 19296
		private int _Hits;

		// Token: 0x04004B61 RID: 19297
		private int _Misses;
	}
}
