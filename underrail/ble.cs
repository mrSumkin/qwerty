using System;
using Microsoft.Xna.Framework;

// Token: 0x02000675 RID: 1653
[eiz("iTLAC")]
public interface ble
{
	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06002A0A RID: 10762
	b0b ActorEntity { get; }

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06002A0B RID: 10763
	string ActorId { get; }

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06002A0C RID: 10764
	string ActorName { get; }

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06002A0D RID: 10765
	string ActorPortrait { get; }

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06002A0E RID: 10766
	Color? ActorColor { get; }
}
