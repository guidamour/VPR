import Dashboard from 'components/dashboard'
import mRegistrants from 'components/Registrants/manageRegistrants'
import pApplication from 'components/Registrants/pApplication'
import monthUpdate from 'components/Registrants/monthUpdate'
import quickReports from 'components/Reporting/quickReports'
import shapefile from 'components/Reporting/shapefile'
import InterativeReports from 'components/Reporting/InterativeReports'
import help from 'components/help'
import ClientManagement from 'components/ClientManagement'
import Administration from 'components/Administration'
import userAccount from 'components/userAccount'
import websiteManagement from 'components/websiteManagement'
import Login from 'components/loginForm'

export const routes = [
  { name: 'Home', path: '/', component: Dashboard, display: 'Home' },
  { name: 'Login', path: '/login', component: Login, display: 'Login' },
  { name: '', path: '/fetch-data', component: Dashboard, display: 'Fetch data' },
  { name: 'Dashboard', path: '/dashboard', component: Dashboard, display: 'Dashboard' },
  {
    name: 'ManageRegistrants',
    path: '/manageregistrants',
    component: mRegistrants,
    dispplay: 'Manage Registrants',
    meta: { requiresAuth: true }
  },
  {
    name: 'PendingApplication',
    path: '/pendingapplication',
    component: pApplication,
    display: 'Pending Application',
    meta: { requiresAuth: true }
  },
  {
    name: '6MonthUpdates',
    path: '/6monthupdates',
    component: monthUpdate,
    display: '6 Month Updates',
    meta: { requiresAuth: true }
  },
  {
    name: 'QuickReports',
    path: '/quickreports',
    component: quickReports,
    display: 'Quick Reports',
    meta: { requiresAuth: true }
  },
  { name: 'ShapeFile', path: '/shapefile', component: shapefile, display: 'Shape File' },
  {
    name: 'InterativeReports',
    path: '/interactivereports',
    component: InterativeReports,
    display: 'Interative Reports',
    meta: { requiresAuth: true }
  },
  { name: 'Help', path: '/help', component: help, display: 'Help' },
  {
    name: 'ClientManagement',
    path: '/ClientManagement',
    component: ClientManagement,
    display: 'Client Management',
    meta: { requiresAuth: true }
  },
  {
    name: 'Administration',
    path: '/Administration',
    component: Administration,
    display: 'Administration',
    meta: { requiresAuth: true }
  },
  {
    name: 'UserAccounts',
    path: '/useraccount',
    component: userAccount,
    display: 'User Account',
    meta: { requiresAuth: true }
  },
  {
    name: 'WebisteManagement',
    path: '/websitemanagement',
    component: websiteManagement,
    display: 'Webiste Management',
    meta: { requiresAuth: true }
  }
];
